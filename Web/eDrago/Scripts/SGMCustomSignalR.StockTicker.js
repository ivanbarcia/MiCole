/// <reference path="../Scripts/jquery-1.10.2.js" />
/// <reference path="../Scripts/jquery.signalR-2.2.2.js" />

// Crockford's supplant method (poor man's templating)
if (!String.prototype.supplant) {
    String.prototype.supplant = function (o) {
        return this.replace(/{([^{}]*)}/g,
            function (a, b) {
                var r = o[b];
                return typeof r === 'string' || typeof r === 'number' ? r : a;
            }
        );
    };
}

// A simple background color flash effect that uses jQuery Color plugin
jQuery.fn.flash = function (color, duration) {
    var current = this.css('color');
    this.animate({ color: 'rgb(' + color + ')' }, duration / 2)
        .animate({ color: current }, duration / 2);
};

$(function () {
    var ticker = $.connection.stockTicker, // the generated client-side hub proxy
        up = "<span class='glyphicon glyphicon-chevron-up'></span>"/*'▲'*/,
        down = "<span class='glyphicon glyphicon-chevron-down'></span>"/*'▼'*/,
        $stockTable = $('#stockTable'),
        $stockTableBody = $stockTable.find('tbody'),
        rowTemplate = '<tr class="fila" data-symbol="{Symbol}"><td class="simbolo">{Symbol}</td><td>{Price}</td><td>{DayOpen}</td><td>{DayHigh}</td><td>{DayLow}</td><td><div class="change"><span class="dir {DirectionClass}">{Direction}</span> {Change}</div></td><td><div class="change">{PercentChange}</div></td></tr>',
        $stockTicker = $('#stockTicker'),
        $stockTickerUl = $stockTicker.find('ul'),
        liTemplate = '<li data-symbol="{Symbol}" class="col-lg-2 custom-border"><span class="symbol">{Description}</span> <span class="price">{Price}</span> <br/> <span class="change"><span class="dir {DirectionClass}">{Direction}</span> {Change} ({PercentChange})</span></li>';

    function formatStock(stock) {
        return $.extend(stock, {
            Price: stock.Price.toFixed(2),
            PercentChange: (stock.PercentChange * 100).toFixed(2) + '%',
            Direction: stock.Change === 0 ? '' : stock.Change >= 0 ? up : down,
            DirectionClass: stock.Change === 0 ? 'even' : stock.Change >= 0 ? 'up' : 'down'
        });
    }

    function scrollTicker() {
        //var w = $stockTickerUl.width();
        //$stockTickerUl.css({ marginLeft: w });
        //$stockTickerUl.animate({ marginLeft: -w }, 15000, 'linear', scrollTicker);
    }

    function stopTicker() {
        $stockTickerUl.stop();
    }

    function init() {
        return ticker.server.getAllStocks().done(function (stocks) {
            $stockTableBody.empty();
            $stockTickerUl.empty();
            $.each(stocks, function () {
                var stock = formatStock(this);
                $stockTableBody.append(rowTemplate.supplant(stock));
                $stockTickerUl.append(liTemplate.supplant(stock));
            });
        });
    }

    function removerUltimoBorde() {
        $stockTicker.find('ul')[0].lastChild.className = "col-lg-2";
    }

    // Add client-side hub methods that the server will call
    $.extend(ticker.client, {
        updateStockPrice: function (stock) {
            var displayStock = formatStock(stock),
                $row = $(rowTemplate.supplant(displayStock)),
                $li = $(liTemplate.supplant(displayStock)),
                bg = stock.Change < 0
                        ? '255,74,104' // red
                        : '60,188,152'; // green

            $row.find('div[class="change"]').css('color', 'rgb(' + bg + ')');
            $li.find('span[class="change"]').css('color', 'rgb(' + bg + ')');

            // .replace("&","") SOLO PARA EL CASO DE S&P500
            //stock.Symbol = stock.Symbol.replace("&", "");

            $stockTableBody.find('tr[data-symbol=' + stock.Symbol + ']')
                .replaceWith($row);
            if ($stockTickerUl[0].children.length > 1) {
                if ($stockTickerUl[0].lastChild.attributes.getNamedItem("data-symbol").nodeValue === stock.Symbol) {
                    $li.removeClass("custom-border");
                }
            }

            $stockTickerUl.find('li[data-symbol=' + stock.Symbol + ']')
                .replaceWith($li);

            //$row.find('div[class="change"]').flash(bg, 1000);
            //$li.find('span[class="change"]').flash(bg, 1000);
        },

        marketOpened: function () {
            $("#open").prop("disabled", true);
            $("#close").prop("disabled", false);
            $("#reset").prop("disabled", true);
            scrollTicker();
        },

        marketClosed: function () {
            $("#open").prop("disabled", false);
            $("#close").prop("disabled", true);
            $("#reset").prop("disabled", false);
            stopTicker();
        },

        marketReset: function () {
            return init();
        }
    });

    // Start the connection
    $.connection.hub.start()
        .then(init)
        .then(removerUltimoBorde)
        .then(function () {
            return ticker.server.getMarketState();
        })
        .done(function (state) {
            if (state === 'Open') {
                ticker.client.marketOpened();
            } else {
                ticker.client.marketClosed();
            }

            // Wire up the buttons
            $("#open").click(function () {
                ticker.server.openMarket();
            });

            $("#close").click(function () {
                ticker.server.closeMarket();
            });

            $("#reset").click(function () {
                ticker.server.reset();
            });
        });
});