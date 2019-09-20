function showDetailsConfirmacion(oper_numero) {

    numeroOperacion = oper_numero;

    var serviceUrl = '/Operaciones/OperacionTipo';
    var url = (window.BASE_URL == null) ? serviceUrl : window.BASE_URL + serviceUrl;
    var oper = oper_numero;

    $.getJSON({
        url: url,
        type: 'GET',
        data: { operacion: oper_numero },
        success: function (data) {
            if (data == 'FCI') {
                loadConfirmacionFCI(oper);
            }
            else {
                loadConfirmacion(oper);
            }
        },
    });
}

function loadConfirmacion(oper_numero) {

    var url = $('#modalZoomConfirmacion').data('url');

    $.getJSON({
        url: url,
        type: 'GET',
        data: { operacion: oper_numero },
        success: function (data) {
            $('#txtCodigoSector').val(data.CodigoSector);
            $('#txtSector').val(data.Sector);
            $('#txtCapital').val(data.Capital);
            $('#txtFechaAlta').val(parseJsonDate(data.FechaAlta));
            $('#txtUsuario').val(data.Usuario);
            $('#txtPlazo').val(data.Plazo);
            $('#txtPase').val(data.Pase);
            $('#txtInteres').val(data.Interes);

            if (data.TNA == null) {
                $('#txtTNA').hide();
            }
            else {
                $('#txtTNA').val(data.TNA);
            }

            if (data.Precio == null) {
                $('#txtPrecio').hide();
            }
            else {
                $('#txtPrecio').val(data.Precio);
            }

            $('#txtFechaOrigen').val(parseJsonDate(data.FechaOrigen));
            $('#txtFechaVence').val(parseJsonDate(data.FechaVence));
            $('#txtEstado').val(data.Estado);
            $('#txtMonto').val(data.Monto);
            $('#txtTipoOperacion').val(data.TipoOperacion);
            $('#txtSupervisor').val(data.Supervisor);
            $('#txtCliente').val(data.Cliente);
            $('#txtFechaSupervision').val(parseJsonDate(data.FechaSupervision));
            $('#txtEspecie').val(data.Especie);
            $('#txtCupon').val(data.Cupon);
            $('#txtVR').val(data.VR);
            $('#txtMercado').val(data.Mercado);
            $('#txtBoleto').val(data.NumeroBoleto);
            $('#txtCorresponsal').val(data.Corresponsal);
            $('#txtOrden').val(data.NumeroOrden);
            $('#txtCorredor').val(data.Corredor);
            $('#txtComision').val(data.Comision);
            $('#txtResponsableComercial').val(data.ResponsableComercial);
            $('#txtIVAComision').val(data.IVAComision);
            $('#txtMargenOperador').val(data.MargenOperador);
            $('#txtSecuenciaMAE').val(data.SecuenciaMAE);
            $('#txtIdSideba').val(data.IDSIDEBA);
            $('#txtConcepto').val(data.Concepto);
            $('#txtTipoReferencia').val(data.TipoReferencia);
            $('#txtCodigoReferencia').val(data.CodigoReferencia);
            $('#txtSuperaLimiteEfectivo').val(data.SuperaLimiteEfectivo);
            $('#txtObservacion').val(data.Observacion);
            $('#txtNumeroCertificado').val(data.NumeroCertificado);
            $('#txtMonedaNegociacion').val(data.MonedaNegociacion);
            $('#txtCuentaCustodia').val(data.CuentaCustodia);
            $('#txtTipoAforo').val(data.TipoAforo);
            $('#txtAforo').val(data.Aforo);

            if (data.CalifClienteCalificacion == null) {
                $('#panelCalificacionCliente').hide();
            }
            $('#txtCalifClienteCalificacion').val(data.CalifClienteCalificacion);
            $('#txtCalifClienteUtilizado').val(data.CalifClienteUtilizado);
            $('#txtCalifClienteMargen').val(data.CalifClienteMargen);

            if (data.ContraOperNumeroOperacion == null) {
                $('#panelContraOperacion').hide();
            }
            $('#txtContraOperNumeroOperacion').val(data.ContraOperNumeroOperacion);
            $('#txtContraOperTipoOperacion').val(data.ContraOperTipoOperacion);
            $('#txtContraOperEspecie').val(data.ContraOperEspecie);
            $('#txtContraOperCorresponsal').val(data.ContraOperCorresponsal);
            $('#txtContraOperCapital').val(data.ContraOperCapital);
            $('#txtContraOperPrecio').val(data.ContraOperPrecio);
        },
    });

    $("#modalZoomConfirmacion").modal({
        backdrop: "static"
    });
}

function loadConfirmacionFCI(oper_numero) {

    var url = $('#modalZoomConfirmacionFCI').data('url');

    $.getJSON({
        url: url,
        type: 'GET',
        data: { operacion: oper_numero },
        success: function (data) {
            $('#txtOrden').val(data.Orden);
            $('#txtOrden2').val(data.Orden2);
            $('#txtTipo').val(data.Tipo);
            $('#txtPrecio').val(data.Precio);
            $('#txtFechaAlta').val(parseJsonDate(data.FechaAlta));
            $('#txtCantidadCuotapartes').val(data.CantidadCuotapartes);
            $('#txtUsuario').val(data.Usuario);
            $('#txtCuentaCuotapartista').val(data.CuentaCuotapartista);
            $('#txtNumeroSolicitud').val(data.NumeroSolicitud);
            $('#txtEspecie').val(data.Especie);
            $('#txtResponsableComercial').val(data.ResponsableComercial);
            $('#txtMonedaNegociacion').val(data.MonedaNegociacion);
            $('#txtResponsableInversion').val(data.ResponsableInversion);
        },
    });

    $("#modalZoomConfirmacionFCI").modal({
        backdrop: "static"
    });
}