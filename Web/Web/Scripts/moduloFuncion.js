function ModuloFuncionViewModel() {
    var self = this;

    /******************************************************************/


    self.Save = function () {
        var serviceUrl = "/ModuloFuncion/Save";

        var matrixIds = [];
        var table = document.getElementById('moduloFuncion');

        for (var r = 1, n = table.rows.length; r < n; r++) {

            for (var c = 1, m = table.rows[r].cells.length; c < m; c++) {
                if (table.rows[r].cells[c].childNodes.length != 1) {

                    try {
                        if (matrixIds[r].length != 0) {
                            matrixIds[r][c] = table.rows[r].cells[c].childNodes['1'].value;
                        }
                    }
                    catch (err) {
                        matrixIds[r] = [];
                        matrixIds[r][c] = table.rows[r].cells[c].childNodes['1'].value;
                    }
                    
                } 
            }
        }
       
        var matrix = [];
        var table = document.getElementById('moduloFuncion');

        for (var r = 1, n = table.rows.length; r < n; r++) {
            
            for (var c = 1, m = table.rows[r].cells.length; c < m; c++) {
                if (table.rows[r].cells[c].childNodes.length != 1) {

                    try {
                        if (matrix[r].length != 0) {
                            matrix[r][c] = table.rows[r].cells[c].childNodes['1'].checked ? 1 : 0;
                        }
                    }
                    catch (err) {
                        matrix[r] = [];
                        matrix[r][c] = table.rows[r].cells[c].childNodes['1'].checked ? 1 : 0;
                    }
                }
            }
        }

        $.ajax({
            type: "POST",
            url: (window.BASE_URL == null) ? serviceUrl : window.BASE_URL + serviceUrl,
            data: JSON.stringify({
                moduloFuncionIds: matrixIds,
                moduloFuncionChecks: matrix
            }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            traditional: true,
            complete: function (data) {
                swal({
                    text: 'Datos guardados!',
                    type: 'success',
                    showCloseButton: true
                });
                window.location.href = (window.BASE_URL == null) ? "/ModuloFuncion/Index" : window.BASE_URL + "/ModuloFuncion/Index";
            }
        });
    };

}

$(document).ready(function () {

    ko.applyBindings(new ModuloFuncionViewModel());

});

$(document).ajaxStart(function () {
    $.blockUI({
        message: $("<div><img src=" + window.BASE_URL + "/Images/SPINNER.GIF" + "" + "> &nbsp; &nbsp; &nbsp; &nbsp;PROCESANDO...</div>"),
        css: {
            border: 'none',
            padding: '15px',
            backgroundColor: '#000',
            '-webkit-border-radius': '10px',
            '-moz-border-radius': '10px',
            opacity: .5,
            color: '#fff'
        }
    });
}).ajaxStop($.unblockUI);

