<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>AjaxSon</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap-datetimepicker.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="panel">
                    <div style="background-color: lightblue" class="col-md-10 col-md-offset-1 panel-heading panel-primary">
                        Filtro de Información
                    </div>
                    <div style="background-color: lightgoldenrodyellow" class="col-md-10 col-md-offset-1 panel-body panel-default">
                        <div class="col-md-3">
                            <input type="text" id="txtFolQueja" placeholder="Folio Queja" class="form-control" />
                        </div>
                        <div class="col-md-3">
                            <select id="dllUnidadNeg" class="form-control">
                                <option value="0">[Elije Unidad de Negocio]</option>
                            </select>
                        </div>
                        <div class="col-md-3">
                            <select id="dllTipoServ" class="form-control">
                                <option>[Elije Tipo de Servicio]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                        </div>
                        <div class="col-md-3">
                            <select id="dllEjecSac" class="form-control">
                                <option>[Elije Ejecutivo SAC]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                            <br />
                        </div>
                        <div class="col-md-3">
                            <input type="text" id="txtNumServicio" placeholder="Número de Servicio" class="form-control" />
                        </div>
                        <div class="col-md-3">
                            <select id="dllCliente" class="form-control">
                                <option>[Elije Cliente]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                        </div>
                        <div class="col-md-3">
                            <select id="dllEtapa" class="form-control">
                                <option>[Elije Etapa]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                        </div>
                        <div class="col-md-3">
                            <select id="dllDefincion" class="form-control">
                                <option>[Elije Definición]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                            <br />
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <div class='input-group date'>
                                    <input type='text' class="form-control" id='datetimepicker2' />
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-calendar"></span>
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <div class='input-group date'>
                                    <input type='text' class="form-control" id='datetimepicker3' />
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-calendar"></span>
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <select id="dllEstado" class="form-control">
                                <option value="0">[Elije Estado]</option>
                            </select>
                        </div>
                        <div class="col-md-3">
                            <select id="dllMunicipio" class="form-control">
                                <option>[Elije Municipio]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                        </div>
                        <div class="col-xs-4 col-xs-offset-4" style="text-align: center;">
                            <label class="btn btn-info btn-sm" id="lblBuscar" style="width: 75%;">Buscar</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-10 col-md-offset-1" style="overflow-x: scroll; padding-left: 0px; padding-right: 0px; padding-top: 10px;" id="divTablaGestion">
                </div>
            </div>
            <div class="modal fade" id="datosReporte" tabindex="-1" role="dialog" data-backdrop="static">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" id="btnCerrar" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                            <h4 class="modal-title" id="exampleModalLabel">Datos del Servicio</h4>
                        </div>
                        <div class="modal-body">
                            <div class="panel">
                                <div class="row">
                                    <div class="panel" id="divPanel">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer" id="divFooter">
                        </div>
                        <%--data-trigger="focus"--%>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="js/jquery-2.2.0.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/moment-with-locales.js"></script>
    <script src="js/bootstrap-datetimepicker.js"></script>
    <script src="js/main.js"></script>
</body>
</html>
