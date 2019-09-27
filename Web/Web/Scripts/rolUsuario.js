function RolUsuarioViewModel() {
    var self = this;

    /******************************************************************/

    self.Save = function () {
        var serviceUrl = "/RolUsuario/Save";
        var usuario = document.getElementById('NombreUsuario').value;
        var matrixIds = [];
        var table = document.getElementById('rolUsuario');

        for (var r = 1; r < table.rows.length; r++) {
            matrixIds[r] = [];
            matrixIds[r][0] = table.rows[r].cells[0].childNodes['0'].value;
            matrixIds[r][1] = table.rows[r].cells[3].childNodes['1'].checked;
        }

        setTimeout(function () {
            $.ajax({
                type: "POST",
                url: (window.BASE_URL == null) ? serviceUrl : window.BASE_URL + serviceUrl,
                data: JSON.stringify({
                    rolUsuarioIds: matrixIds,
                    usuario: usuario

                }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                traditional: true,
                complete: function (data) {
                    swal({
                        text: 'Datos guardados!',
                        type: 'success'
                    });
                    window.location.href = (window.BASE_URL == null) ? "/RolUsuario/Index" : window.BASE_URL + "/RolUsuario/Index";
                }
            });
        }, 500);
    };

}

$(document).ready(function () {
    ko.applyBindings(new RolUsuarioViewModel());
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

