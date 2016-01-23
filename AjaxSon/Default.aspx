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
                        <div class="col-md-2 col-md-offset-2">
                            <input type="text" id="txtFolQueja" placeholder="Folio Queja" class="form-control" />
                        </div>
                        <div class="col-md-2">
                            <select id="dllUnidadNeg" class="form-control">
                                <option value="0">[Elije Unidad de Negocio]</option>
                            </select>
                        </div>
                        <div class="col-md-2">
                            <select id="dllTipoServ" class="form-control">
                                <option>[Elije Tipo de Servicio]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                        </div>
                        <div class="col-md-2">
                            <select id="dllEjecSac" class="form-control">
                                <option>[Elije Ejecutivo SAC]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                            <br />
                        </div>
                        <div class="col-md-2 col-md-offset-2">
                            <input type="text" id="txtNumServicio" placeholder="Número de Servicio" class="form-control" />
                        </div>
                        <div class="col-md-2">
                            <select id="dllCliente" class="form-control">
                                <option>[Elije Cliente]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                        </div>
                        <div class="col-md-2">
                            <select id="dllEtapa" class="form-control">
                                <option>[Elije Etapa]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                        </div>
                        <div class="col-md-2">
                            <select id="dllDefincion" class="form-control">
                                <option>[Elije Definición]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                            <br />
                        </div>
                        <div class="col-md-2 col-md-offset-2">
                            <div class="form-group">
                                <div class='input-group date' id='datetimepicker2'>
                                    <input type='text' class="form-control" />
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-calendar"></span>
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-2">
                            <div class="form-group">
                                <div class='input-group date' id='datetimepicker3'>
                                    <input type='text' class="form-control" />
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-calendar"></span>
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-2">
                            <select id="dllEstado" class="form-control">
                                <option>[Elije Estado]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                        </div>
                        <div class="col-md-2">
                            <select id="dllMunicipio" class="form-control">
                                <option>[Elije Municipio]</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                            </select>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-10 col-md-offset-1" style="overflow-x: scroll; padding-left: 0px; padding-right: 0px; padding-top: 10px;">
                    <table class="table table-responsive table-hover" id="tablaEncabezado" style="font-size: 0.7em;">
                        <tr style="background-color: #F2F7FA; text-align: center; font-weight: 900;">
                            <td colspan="7">Total de Quejas X Causa: 14</td>
                            <td>0</td>
                            <td>0</td>
                            <td>0</td>
                            <td>0</td>
                            <td>0</td>
                            <td>0</td>
                            <td>0</td>
                        </tr>
                        <tr style="background-color: #F2F7FA; text-align: center; font-weight: 900;">
                            <td>[Folio Queja]</td>
                            <td>[Causa]</td>
                            <td>[No. Servicio]</td>
                            <td>[Unidad de Negocio]</td>
                            <td>[Cliente]</td>
                            <td>[Tipo de Servicio]</td>
                            <td>[Recepción de Queja]</td>
                            <td>[Asignar Ejecutivos]</td>
                            <td>[Asignacion Responsables]</td>
                            <td>[Contacto Responsable]</td>
                            <td>[Recabar Informacion]</td>
                            <td>[Solucion]</td>
                            <td>[Contacto Solucion]</td>
                            <td>[Accion Siguiente]</td>
                        </tr>
                        <tr>
                            <td>2016CG1000</td>
                            <td>El Gestor no fue amable con cliente	</td>
                            <td>2016131043499</td>
                            <td>Concierge</td>
                            <td>Credinissan (GO)</td>
                            <td>Gestoría para Indemnización PT Daños Materiales	</td>
                            <td>18/01/2016 17:26</td>
                            <td>Diana Cynthia Tolentino HernándeZ</td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>
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
