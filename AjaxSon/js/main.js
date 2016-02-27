$(document).ready(function () {
    //Configuracion de Datetimepickers
    $('[id*=datetimepicker]').datetimepicker({
        locale: 'es',
        format: 'LT L',
        icons: {
            previous: 'glyphicon glyphicon-arrow-right'
        }
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
            var list = $.parseJSON(msg.d);
            var tabla = '';
            var estado = '';
            $(list[0]).each(function () {
                tabla += '<option value="' + this.Id + '">' + this.Nombre + '</option>';
            });
            $('#dllUnidadNeg').append(tabla);
            $(list[1]).each(function () {
                estado += '<option value="' + this.Id + '">' + this.Nombre + '</option>';
            });
            $('#dllEstado').append(estado);
        },
        error: function (msg) {
            alert('Error cargar unidad de negocio, ' + msg.responseText);
        }
    });// Fin Ajax

    //Evento Change de unidad de negocio con carga de tablero principal
    $('#dllUnidadNeg').change(function () {
        if ($('#dllUnidadNeg').val() != 0) {
            CargarTabla();
        }
    });
    $('#lblBuscar').on("click", function () {
        CargarTabla();
    });
    function CargarTabla() {
        var fechaInicial = $('#datetimepicker2').val() == '' ? '01/01/2000' : $('#datetimepicker2').val();
        var FechaFinal = $('#datetimepicker3').val() == '' ? '02/06/2016' : $('#datetimepicker3').val();
        var Queja = '';
        //var UnidadNegocio = $('#dllUnidadNeg option:selected').html();
        var UnidadNegocio = $('#dllUnidadNeg').val();
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
                tabla += ' <tr style="background-color: #F2F7FA; text-align: center; font-weight: 600;">';
                tabla += '  <td colspan="7">Total de Quejas X Causa: 14</td>';
                tabla += '  <td>0</td>';
                tabla += '  <td>0</td>';
                tabla += '  <td>0</td>';
                tabla += '  <td>0</td>';
                tabla += '  <td>0</td>';
                tabla += '  <td>0</td>';
                tabla += '  <td>0</td>';
                tabla += ' </tr>';
                tabla += '<tr style="background-color: #F2F7FA; text-align: center; font-weight: 600;">';
                tabla += ' <td>[Folio Queja]</td>';
                tabla += ' <td>[Causa]</td>';
                tabla += ' <td>[No. Servicio]</td>';
                tabla += ' <td>[Unidad de Negocio]</td>';
                tabla += ' <td>[Cliente]</td>';
                tabla += ' <td>[Tipo de Servicio]</td>';
                tabla += ' <td>[Recepción de Queja]</td>';
                tabla += ' <td>[Asignar Ejecutivos]</td>';
                tabla += ' <td>[Asignacion Responsables]</td>';
                tabla += ' <td>[Contacto Responsable]</td>';
                tabla += ' <td>[Recabar Informacion]</td>';
                tabla += ' <td>[Solucion]</td>';
                tabla += ' <td>[Contacto Solucion]</td>';
                tabla += ' <td>[Accion Siguiente]</td>';
                tabla += '</tr>';
                $(list).each(function () {
                    tabla += '<tr style="text-align:center;">';
                    tabla += ' <td><a href="#" id="lnkCausa' + this.CausaId + '">' + this.Queja + '</a></td>';
                    tabla += ' <td>' + this.Descripcion + '</td>';
                    tabla += ' <td>' + this.NumServicio + '</td>';
                    tabla += ' <td>' + this.UnidadNegocio + '</td>';
                    tabla += ' <td>' + this.ClienteNombre + '</td>';
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
        $('[id*=lnkCausa]').on("click", function () {

            $('#datosReporte').modal('show');
            //alert('Me hiciste click :), ' + $(this).attr("id"));
        });
    }//Fin de CargarTabla()

    //var popoverContent = ['<div class="row">',
    //    '<button type="button" id="btnClicAqui" class="btn btn-default">Clic Aqui</button>',
    //    '<button type="button" id="btnClicAqui" class="btn btn-default">Clic Aqui</button>">',
    //    '</div>'].join('');

    //$('#btnPopover').popover({
    //    html: true,
    //    content: popoverTemplate
    //});
    //if ($('#btnCerrar').on("click", function () {
    //    $('#datosReporte').modal('handleUpdate');
    //}));

    if ($('#datosReporte').on('hidden.bs.modal','.modal', function () {
        $('#txtCausa,#txtNoServicio').val() = '';
    }));

    $('#btnPopover').on("click", function () {
        $('#btnPopover').popover('show');

        $('#btnHola').on("click", function () {
            alert('Hola Mundo');
        });
    });
    $('#btnClicAqui').on("click", function () {
        alert('Wuaoooooo');
    });
});//Fin del ready