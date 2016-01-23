$(document).ready(function () {
    //Configuracion de Datetimepickers
    $('#datetimepicker2').datetimepicker({
        locale: 'es',
    });
    $('#datetimepicker3').datetimepicker({
        locale: 'es'
    });

    $.ajax({
        type: "POST",
        url: "Default.aspx/ObtenerUnidadNegocio",
        data: '{}',
        async: false,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            list = $.parseJSON(msg.d);
            var tabla = '';
            $(list).each(function () {
                tabla += '<option value="' + this.Id + '">' + this.Nombre + '</option>';
            });
            $('#dllUnidadNeg').append(tabla);
        },
        error: function (msg) {
            alert('Error cargar unidad de negocio, ' + msg.responseText);
        }
    });// Fin Ajax
});