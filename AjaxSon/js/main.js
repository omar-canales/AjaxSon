$(document).ready(function () {
    //Configuracion de Datetimepickers
    $('#datetimepicker2').datetimepicker({
        locale: 'es',
    });
    $('#datetimepicker3').datetimepicker({
        locale: 'es'
    });


    //Carga de DDL's
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

    //Evento Change de unidad de negocio con carga de tablero principal
    $('#dllUnidadNeg').change(function () {
        if ($('#dllUnidadNeg').val() != 0) {
            var fechaInicial = $('#datetimepicker2').val();
            var FechaFinal = $('#datetimepicker3').val();
            var Queja = '';
            var UnidadNegocio = $('#dllUnidadNeg option:selected').html();
            var TipoServicio = '';
            var EjecutivoSAC = '';
            var NoServicio = '';
            var Cliente = '';
            var Etapa = '';
            var Definicion = '';
            var Estado = '';
            var Municipio = '';

            var misDatos = '{"fechaInicial":"' + fechaInicial + '","FechaFinal":"' + FechaFinal + '","Queja":"' + Queja + '","UnidadNegocio":"' + UnidadNegocio + '","TipoServicio":"' + TipoServicio + '","EjecutivoSAC":"' + EjecutivoSAC + '","NoServicio":"' + NoServicio + '","Cliente":"' + Cliente + '","Etapa":"' + Etapa + '","Definicion":"' + Definicion + '","Estado":"' + Estado + '","Municipio":"' + Municipio + '"}';
            $.ajax({
                type: "POST",
                url: "Default.aspx/ObtenerTableroGestion",
                data: misDatos,
                async: false,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    list = $.parseJSON(msg.d);
                    var tabla = '';
                    tabla += '<table class="table table-responsive table-hover" id="tablaEncabezado" style="font-size: 0.7em;">';
                    tabla += ' <tr style="background-color: #F2F7FA; text-align: center; font-weight: 900;">';
                    tabla += '  <td colspan="7">Total de Quejas X Causa: 14</td>';
                    tabla += '  <td>0</td>';
                    tabla += '  <td>0</td>';
                    tabla += '  <td>0</td>';
                    tabla += '  <td>0</td>';
                    tabla += '  <td>0</td>';
                    tabla += '  <td>0</td>';
                    tabla += '  <td>0</td>';
                    tabla += ' </tr>';
                    tabla += ' <tr style="background-color: #F2F7FA; text-align: center; font-weight: 900;">';
                    tabla += '  <td>[Folio Queja]</td>';
                    tabla += '  <td>[Causa]</td>';
                    tabla += '  <td>[No. Servicio]</td>';
                    tabla += '  <td>[Unidad de Negocio]</td>';
                    tabla += '  <td>[Cliente]</td>';
                    tabla += '  <td>[Tipo de Servicio]</td>';
                    tabla += '  <td>[Recepción de Queja]</td>';
                    tabla += '  <td>[Asignar Ejecutivos]</td>';
                    tabla += '  <td>[Asignacion Responsables]</td>';
                    tabla += '  <td>[Contacto Responsable]</td>';
                    tabla += '  <td>[Recabar Informacion]</td>';
                    tabla += '  <td>[Solucion]</td>';
                    tabla += '  <td>[Contacto Solucion]</td>';
                    tabla += '  <td>[Accion Siguiente]</td>';
                    tabla += ' </tr>';
                    $(list).each(function () {
                        tabla += '<tr style="text-align:center;">';
                        tabla += ' <td>' + this.Queja + '</td>';
                        tabla += ' <td>' + this.Descripcion + '</td>';
                        tabla += ' <td>' + this.NumServicio + '</td>';
                        tabla += ' <td>' + this.Sistema + '</td>';
                        tabla += ' <td>' + this.Cliente + '</td>';
                        tabla += ' <td>' + this.NombServicio + '</td>';
                        tabla += ' <td>' + this.fAlta; + '</td>';
                        tabla += ' <td>Diana Cynthia Tolentino HernándeZ</td>';
                        tabla += ' <td></td>';
                        tabla += ' <td></td>';
                        tabla += ' <td></td>';
                        tabla += ' <td></td>';
                        tabla += ' <td></td>';
                        tabla += ' <td></td>';
                        tabla += '</tr>';
                    });
                    tabla += '</table>';
                    $('#divTablaGestion').empty();
                    $('#divTablaGestion').append(tabla);
                },
                error: function (msg) {
                    alert('Error cargar el tablero de Gestion, ' + msg.responseText);
                }
            });// Fin Ajax
        }
    });
});