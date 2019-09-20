function validarFecha(value) {

    var valor = value;

    // Comprobación del patrón ingresado
    if (!/^\d{1,2}\/\d{1,2}\/\d{4}$/.test(valor)){
        alert("Error: La fecha no tiene el formato correcto");
        return 1;
    }

    // Parseo de cada parte de la fecha
    var parts = valor.split("/");
    var day = parseInt(parts[0], 10);
    var month = parseInt(parts[1], 10);
    var year = parseInt(parts[2], 10);

    // Comprobación del año y mes
    if (year < 1000 || year > 3000 || month <= 0 || month > 12){
        alert("Error: La fecha no tiene el formato correcto");
        return 1;
    }

    var monthLength = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

    // Adjuste año bisiesto
    if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))
        monthLength[1] = 29;

    // Comprobación del día
    if (day <= 0 || day > monthLength[month - 1]) {
        alert("Error: La fecha no tiene el formato correcto");
        return 1;
    }
    return 0;
};

function compararFechas(value1, value2) {
    var fechaDesde = value1;
    var fechaHasta = value2;

    // Parseo de cada parte de las fechas
    var parts1 = fechaDesde.split("/");
    var diaDesde = parseInt(parts1[0], 10);
    var mesDesde = parseInt(parts1[1], 10);
    var anioDesde = parseInt(parts1[2], 10);

    var parts2 = fechaHasta.split("/");
    var diaHasta = parseInt(parts2[0], 10);
    var mesHasta = parseInt(parts2[1], 10);
    var anioHasta = parseInt(parts2[2], 10);

    if (anioDesde > anioHasta) {
        alert("Error: La fecha inicial no puede ser mayor a la siguiente");
        return 1;
    }
    else if ((anioDesde == anioHasta) && (mesDesde > mesHasta)) {
        alert("Error: La fecha inicial no puede ser mayor a la siguiente");
        return 1;
    }
    else if ((anioDesde == anioHasta) && (mesDesde == mesHasta) && (diaDesde > diaHasta)){
        alert("Error: La fecha inicial no puede ser mayor a la siguiente");
        return 1;
    }
    return 0;
};

//conversor de fecha desde JSON a JS
function parseJsonDate(jsonDateString) {
    if(jsonDateString){
        var dateString = jsonDateString.substr(6);
        var currentTime = new Date(parseInt(dateString));
        var month = currentTime.getMonth() + 1;
        var day = currentTime.getDate();
        var year = currentTime.getFullYear();
        var date = day + "/" + month + "/" + year;
        return date;    
    }
    else {
        return null;
    }
};