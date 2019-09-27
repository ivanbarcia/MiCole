// Import Drawing API namespaces
var draw = kendo.drawing;
var geom = kendo.geometry;

// See
// http://docs.telerik.com/kendo-ui/framework/drawing/drawing-dom#dimensions-and-css-units-for-pdf-output
function mm(val) {
    return val * 2.8347;
}

// A4 Sheet with 1 cm borders, landscape
var PAGE_RECT = new geom.Rect(
  [mm(0), 0], [mm(297 - 20), mm(210 - 20)]
);

// Spacing between header, content and footer
var LINE_SPACING = mm(5);

var scale;

function createHeader() {
    return new kendo.drawing.Text("Reporte", [0, 0], {
        font: mm(8) + "px 'DejaVu Sans'"
    });
}

function createFooter(page, total) {
    return new kendo.drawing.Text(
      kendo.format("Page {0} of {1}", page, total),
      [0, 0], {
          font: mm(3) + "px 'DejaVu Sans'"
      }
    );
}

function formatPage(e) {
    var header = createHeader();
    var content = e.page;
    var footer = createFooter(e.pageNumber, e.totalPages);

    // Remove header, footer and spacers from the page size
    var contentRect = PAGE_RECT.clone();
    contentRect.size.height -= header.bbox().height() + footer.bbox().height() + 2 * LINE_SPACING;

    if (!scale) {
        // Fit the content in the available space
        draw.fit(content, contentRect);
        scale = content.transform().matrix().a;
    }
    else {
        content.transform(kendo.geometry.transform().scale(scale));
    }

    // Do a final layout with content
    var page = new draw.Layout(PAGE_RECT, {
        // "Rows" go below each other
        orientation: "vertical",

        // Center rows relative to each other
        alignItems: "center",

        // Center the content block horizontally
        alignContent: "center",

        // Leave spacing between rows
        spacing: LINE_SPACING
    });
    page.append(header, content);
    page.reflow();

    // Move the footer to the bottom-right corner
    page.append(footer);
    draw.vAlign([footer], PAGE_RECT, "end");
    draw.align([footer], PAGE_RECT, "end");

    return page;
}

