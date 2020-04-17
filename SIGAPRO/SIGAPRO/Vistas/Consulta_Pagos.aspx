<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Consulta_Pagos.aspx.cs" Inherits="SIGAPRO.Vistas.Consulta_Pagos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="bower_components/chartist/dist/chartist.min.css">
    <%-- links para las alertas  --%>
    <script type="text/javascript" src="jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="sweetalert/sweetalert2.min.css">
    <script type="text/javascript" src="sweetalert/sweetalert2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="col-md-12">
            <div class="card">
                <div class="card-header card-header-icon card-header-rose">
                    <div class="card-icon">
                        <i class="material-icons">call_received</i>
                    </div>
                    <h4 class="card-title ">Consulta de Págos</h4>
                </div>
                <br />
                <input id="Btndirije" type="button" class="btn btn-primary col-md-3 ml-auto" value="+ PAGO" data-toggle="modal" data-target="#logoutModalxml" />
                <%--                    <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="+ Pago" OnClick="Button1_Click" />--%>
                <br />
                <asp:Label ID="Label1" class="col-sm-2 col-form-label" runat="server" Text="Busqueda:"></asp:Label><br />
                <div class="row">
                    <div class="col-sm-12">
                        <div class="row">
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label class="bmd-label-floating">N° Factura</label><br />
                                    <asp:TextBox ID="txt_nombre" runat="server" class="form-control" AutoPostBack="True" OnTextChanged="txt_nombre_TextChanged"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label class="bmd-label-floating">Mes</label><br />
                                    <asp:DropDownList ID="DptMes" runat="server" class="selectpicker" data-style="select-with-transition" AutoPostBack="True" OnSelectedIndexChanged="DptMes_SelectedIndexChanged" title="Seleccionar">
                                        <asp:ListItem Value="Seleccionar">Seleccionar</asp:ListItem>
                                        <asp:ListItem Value="01">Enero</asp:ListItem>
                                        <asp:ListItem Value="02">Febrero</asp:ListItem>
                                        <asp:ListItem Value="03">Marzo</asp:ListItem>
                                        <asp:ListItem Value="04">Abril</asp:ListItem>
                                        <asp:ListItem Value="05">Mayo</asp:ListItem>
                                        <asp:ListItem Value="06">Junio</asp:ListItem>
                                        <asp:ListItem Value="07">Julio</asp:ListItem>
                                        <asp:ListItem Value="08">Agosto</asp:ListItem>
                                        <asp:ListItem Value="09">Septiembre</asp:ListItem>
                                        <asp:ListItem Value="10">Octubre</asp:ListItem>
                                        <asp:ListItem Value="11">Noviembre</asp:ListItem>
                                        <asp:ListItem Value="12">Diciembre</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-3">
                                <div class="form-group">
                                    <label class="bmd-label-floating">Estado</label>
                                    <asp:DropDownList ID="Dptestado" runat="server" class="selectpicker" data-style="select-with-transition" OnSelectedIndexChanged="Dptestado_SelectedIndexChanged" title="Seleccionar" AutoPostBack="True">
                                        <asp:ListItem Value="Seleccionar">Seleccionar</asp:ListItem>
                                        <asp:ListItem Value="Si">Paga</asp:ListItem>
                                        <asp:ListItem Value="No">Pendiente</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-2">
                                <div class="form-group">
                                    <label class="bmd-label-floating">Partida</label>
                                    <asp:TextBox ID="TxtPartida" runat="server" class="form-control" AutoPostBack="True" OnTextChanged="TxtPartida_TextChanged"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                        <table class="table">
                            <tbody>

                                <asp:GridView ID="GridVegreso" runat="server" CssClass="table table-striped table-no-bordered" AutoGenerateColumns="False" DataKeyNames="Id_egreso" DataSourceID="SqlDataEgreso" AllowPaging="True" AllowSorting="True" OnRowDataBound="GridVegreso_RowDataBound" OnRowCommand="GridVegreso_RowCommand" OnSelectedIndexChanged="GridVegreso_SelectedIndexChanged">
                                    <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Top" />
                                    <Columns>
                                        <asp:ButtonField Text=" <i style='color:green'class='fas fa-eye fa-2x'></i> " CommandName="Ver" HeaderText="Ver" HeaderStyle-ForeColor="#990099" />
                                        <asp:CommandField ShowSelectButton="True" HeaderText="Editar" SelectText="&lt;i style=&#39;color:orange&#39;class=&#39;fas fa-pen-square fa-2x&#39;&gt;&lt;/i&gt;" HeaderStyle-ForeColor="#990099" />
                                        <asp:BoundField DataField="Id_egreso" HeaderText="Id" ReadOnly="True" InsertVisible="False" SortExpression="Id_egreso"></asp:BoundField>
                                        <asp:BoundField DataField="Digital" HeaderText="Digital" SortExpression="Digital" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="Fecha_ingreso" HeaderText="Fecha ingreso" SortExpression="Fecha_ingreso"></asp:BoundField>
                                        <asp:BoundField DataField="Numero_factura" HeaderText="N° factura" SortExpression="Numero_factura"></asp:BoundField>
                                        <asp:BoundField DataField="Cedula_Juridica" HeaderText="Cedula_Juridica" SortExpression="Cedula_Juridica" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="Existe_fisica" HeaderText="Existe_fisica" SortExpression="Existe_fisica" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="GTI" HeaderText="GTI" SortExpression="GTI"></asp:BoundField>
                                        <asp:BoundField DataField="Nombre_comercio" HeaderText="Comercio" SortExpression="Nombre_comercio"></asp:BoundField>
                                        <asp:BoundField DataField="Id_detalle" HeaderText="Id_detalle" SortExpression="Id_detalle" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="Id_partida" HeaderText="Partida" SortExpression="Id_partida"></asp:BoundField>
                                        <asp:BoundField DataField="Monto_factura" HeaderText="Monto" SortExpression="Monto_factura"></asp:BoundField>
                                        <asp:BoundField DataField="Estado_pago" HeaderText="Estado" SortExpression="Estado_pago"></asp:BoundField>
                                        <asp:BoundField DataField="Plazo_pago" HeaderText="Plazo" SortExpression="Plazo_pago"></asp:BoundField>
                                        <asp:BoundField DataField="Nombre_pdf" HeaderText="Nombre_pdf" SortExpression="Nombre_pdf" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="Id_Centro_costos" HeaderText="Centro Costos" SortExpression="Id_Centro_costos"></asp:BoundField>
                                        <asp:BoundField DataField="Id_metodo_pago" HeaderText="Id_metodo_pago" SortExpression="Id_metodo_pago" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="Id_banco" HeaderText="Id_banco" SortExpression="Id_banco" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="Moneda" HeaderText="Moneda" SortExpression="Moneda" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="Tipo_cambio" HeaderText="Tipo_cambio" SortExpression="Tipo_cambio" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="Mes" HeaderText="Mes" SortExpression="Mes"></asp:BoundField>
                                        <asp:BoundField DataField="TotalIva" HeaderText="TotalIva" SortExpression="TotalIva" Visible="False"></asp:BoundField>
                                        <asp:BoundField HeaderText="Aviso" HeaderStyle-ForeColor="Red"></asp:BoundField>
                                        <asp:ButtonField Text=" <i style='color:red'class='fas  fa-file-pdf fa-2x'></i>" CommandName="PDF" HeaderText="PDF" HeaderStyle-ForeColor="#990099" />
                                        <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" Visible="False"></asp:BoundField>
                                    </Columns>
                                    <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <SelectedRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:GridView>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand="SELECT [cedula_usuario], [nombre_usuario], [apellido1], [nick_name], [correo_electronico] FROM [tb_Usuarios_Los_negritos]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDatapartida" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [numero_partida] FROM [tb_Partidas_Los_Negritos]"></asp:SqlDataSource>
    <%-- modal opcional para la gestion de pagos --%>
    <div class="modal fade" id="logoutModalxml" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalRoles">Seleccione una opción.lRoles">Seleccione una opción.</h5>
                    <button class="close" type="button" data-dismiss="modal" aria-label="Cerrar">
                        <span aria-hidden="true">×</span>
                    </button>
                </div>
                <div class="modal-footer">
                    <%-- <asp:Button ID="btnExtraccion" class="btn btn-primary " runat="server" Text="Extracción XML " ForeColor="White" Width="200"  UseSubmitBehavior ="false" OnClick="btnExtraccion_Click" />--%>
                    <input id="Btnxml" type="button" class="btn btn-primary" value="Extraccion XML" data-toggle="modal" data-target="#myModal10" aria-hidden="false" />
                    <asp:Button ID="btnManual" class="btn btn-primary " runat="server" Text="Págo Manual" ForeColor="White" Width="200" UseSubmitBehavior="false" OnClick="btnManual_Click" />
                </div>
            </div>
        </div>
    </div>
    <%-- fin de la modal --%>
    <!-- small modal -->
    <div class="modal fade modal-mini modal-primary" id="myModal10" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog modal-small">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true"><i class="material-icons">clear</i></button>
                </div>
                <div class="modal-body">
                    <p>Seleccione el documento XML</p>
                </div>
                <div class="modal-footer justify-content-center">
                    <div class="fileinput fileinput-new text-center" data-provides="fileinput">
                        <div class="fileinput-new thumbnail">
                            <img src="assets/img/xml.jpg" alt="XML">
                        </div>
                        <div class="fileinput-preview fileinput-exists thumbnail"></div>
                        <div>
                            <span class="btn btn-rose btn-round btn-file">
                                <span class="fileinput-new">
                                    <asp:FileUpload ID="File_XML_Extraccion" runat="server" /></span>
                            </span>
                            <a href="#pablo" class="btn btn-danger btn-round fileinput-exists" data-dismiss="fileinput"><i class="fa fa-times"></i>Quitar</a>
                        </div>
                        <asp:Button class="btn btn-success" ID="btn_Extraccion" runat="server" OnClick="btn_Extraccion_Click" Text="Extraer Datos" Width="178px" />
                    </div>
                </div>
            </div>
        </div>

        <!-- Fin de la modal-->
    </div>
    <%-- Modal para los datos  Creados --%>
    <div class="modal fade" id="ModalDocumentos" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Información del Pago</h5>
                    <br />
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
                    <meta charset="utf-8">
                    <p align="right">ID N°:<asp:Label ID="LblComprobante" Text="" class="col-sm-2 col-form-label" runat="server" ForeColor="Red" Font-Bold="True" /></p>
                    <%--   <div align="center">
                        <img src="assets/img/MovBanc.jpg" width="250" height="150">
                    </div>--%>
                    <p align="center">Comercio :<asp:Label ID="Lblcomercio" class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label></p>
                    <p align="center">Cédula Juridica:<asp:Label ID="LblID_comercio" class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label></p>
                    <table class="egt">
                        <tr>
                            <th>Definición</th>
                            <th></th>
                            <th>Registro</th>
                        </tr>

                        <tr>
                            <td>N° Factura:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lblnumfactura" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Banco:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="LblBanco" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Moneda:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="LblMoneda" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Tipo Cambio:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lbltipo_cambio" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Fecha de Registro:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lblfecha" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Existe fisica:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lblfisica" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Digital/Manual:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lbldigiomanu" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Gti:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="LblGTI" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Detalle:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lbldetalle" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Partida:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lblpartida" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Estado de Pago:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lblestadopago" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>dias faltantes:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lbldias_faltantes" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Plazo Pago:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lblplazo_pago" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Nombre PDF:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="LBLNombrepdf" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Centro de Costos:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="LblCenCos" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Metodo de pago:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="LblMetodoPago" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Mes:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lblmes" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Total IVA:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lbltotal_iva" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>Monto Total:</td>
                            <td></td>
                            <td>
                                <asp:Label ID="Lblmonto_total" class="col-sm-2 col-form-label" runat="server" Text="" ForeColor="#000066"></asp:Label></td>
                        </tr>
                    </table>

                    <br />
                    <div class="modal-footer">                        
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%-- fin de modal  --%>
    <!-- small modal -->
                      <div class="modal fade modal-mini modal-primary" id="myModal100" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                        <div class="modal-dialog modal-small">
                          <div class="modal-content">
                            <div class="modal-header">
                              <button type="button" class="close" data-dismiss="modal" aria-hidden="true"><i class="material-icons">clear</i></button>
                            </div>
                            <div class="modal-body">
                              <p>Que desea Hacer?</p>
                            </div>
                            <div class="modal-footer justify-content-center">
                             <%-- <button type="button" class="btn btn-link" data-dismiss="modal">Never mind</button>--%>
                                <asp:Button ID="BtnModifica" runat="server" Text="Modificar"  class="btn btn-primary" />
                                <asp:Button ID="Eliminar" runat="server" Text="Eliminar"  class="btn btn-danger" />
                             <%-- <button type="button" class="btn btn-success btn-link">Yes--%>
                                <div class="ripple-container"></div>
                              <%--</button>--%>
                            </div>
                          </div>
                        </div>
                      </div>
                      <!--    end small modal -->


    <asp:SqlDataSource ID="SqlDataEgreso" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT * FROM [tb_Egreso_Manual_los_negritos]"></asp:SqlDataSource>
    <!--    end small modal -->
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
    <script type="text/javascript">
        // mensaje de espera 
        function mensajeEspera() {
            let timerInterval
            Swal.fire({
                title: '¡Extrayendo XML Por Favor Espere!',

                timer: 5000,
                allowOutsideClick: false,
                onBeforeOpen: () => {

                    Swal.showLoading()

                    timerInterval = setInterval(() => {
                        Swal.getContent().querySelector('strong')
                            .textContent = (Swal.getTimerLeft() / 1000)
                                .toFixed(0)
                    }, 100)
                },
                onClose: () => {
                    clearInterval(timerInterval)
                }

            })

            window.setTimeout('location.href="Extracion_de_XML.aspx"', 5000)
        }
        function mensajeDeconfirmacion() {
            swal.fire({
                title: "¡EXITO!",
                text: "¡" + "Los Datos se Guardaron Con Exito" + "!",
                type: 'success',
                allowOutsideClick: false,
            })
        }
        // mensaje de error
        // mensaje de error
        function mensajeError() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + " Lo sentimos el archivo no es de tipo XML o este XML ya fue Extraido Por Favor Verifique" + "!",
                type: 'error',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 5000,

            })
        }
        function mensajeErrorPDF() {
            swal.fire({
                title: '¡Aviso!',
                text: "¡" + " No existe PDF en este registro" + "!",
                type: 'warning',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 5000,

            })
        }

    </script>
</asp:Content>
