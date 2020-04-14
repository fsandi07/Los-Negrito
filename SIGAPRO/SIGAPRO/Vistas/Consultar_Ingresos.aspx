<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Consultar_Ingresos.aspx.cs" Inherits="SIGAPRO.Vistas.Consultar_Ingresos" %>

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
                        <i class="material-icons">call_made</i>
                    </div>
                    <h4 class="card-title ">Consulta de Ingresos</h4>
                </div>
                <br />
                <input id="Btndirije" type="button" class="btn btn-primary col-md-3 ml-auto" value="+ INGRESO" data-toggle="modal" data-target="#logoutModalIngreso" />
                <br />

                <%--COMIENZO DEL ROW--%>
                <div class="row">
                    <div class="col-md-8 ml-auto mr-auto">
                        <div class="page-categories">
                            <ul class="nav nav-pills nav-pills-warning nav-pills-icons justify-content-center" role="tablist">
                                <li class="nav-item">
                                    <a class="nav-link active" data-toggle="tab" href="#link7" role="tablist">
                                        <i class="material-icons">info</i>Consulta Ingreso Aves
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link " data-toggle="tab" href="#link8" role="tablist">
                                        <i class="material-icons">location_on</i>Consulta Ingreso Pollinaza
                                    </a>
                                </li>
                            </ul>
                            <div class="tab-content tab-space tab-subcategories">
                                <div class="tab-pane active" id="link7">
                                    <div class="card">
                                        <div class="card-header">
                                        </div>
                                        <div class="card-body">

                                            <div class="table-responsive">

                                                <asp:GridView runat="server" CssClass="table table-striped table-no-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id_ingreso_aves" DataSourceID="SqlDataAves" EnablePersistedSelection="True" AllowPaging="True" AllowSorting="True">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" SelectText="&lt;i style=&#39;color:orange&#39;class=&#39;fas fa-pen-square fa-2x&#39;&gt;&lt;/i&gt;"></asp:CommandField>
                                                        <asp:BoundField DataField="Id_ingreso_aves" HeaderText="Id_ingreso_aves" ReadOnly="True" InsertVisible="False" SortExpression="Id_ingreso_aves"></asp:BoundField>
                                                        <asp:BoundField DataField="Id_partida" HeaderText="Id_partida" SortExpression="Id_partida"></asp:BoundField>
                                                        <asp:BoundField DataField="Estado_pago" HeaderText="Estado_pago" SortExpression="Estado_pago"></asp:BoundField>
                                                        <asp:BoundField DataField="Plazo_de_pago" HeaderText="Plazo_de_pago" SortExpression="Plazo_de_pago"></asp:BoundField>
                                                        <asp:BoundField DataField="Numero_factura_aves" HeaderText="Numero_factura_aves" SortExpression="Numero_factura_aves"></asp:BoundField>
                                                        <asp:BoundField DataField="Nombre_comercio" HeaderText="Nombre_comercio" SortExpression="Nombre_comercio"></asp:BoundField>
                                                        <asp:BoundField DataField="Fecha_emision" HeaderText="Fecha_emision" SortExpression="Fecha_emision"></asp:BoundField>
                                                        <asp:BoundField DataField="Monto_factura" HeaderText="Monto_factura" SortExpression="Monto_factura"></asp:BoundField>
                                                        <asp:BoundField DataField="Detalle_factura" HeaderText="Detalle_factura" SortExpression="Detalle_factura"></asp:BoundField>
                                                        <asp:BoundField DataField="Monto_otra_carga" HeaderText="Monto_otra_carga" SortExpression="Monto_otra_carga"></asp:BoundField>
                                                        <asp:BoundField DataField="Detalle_otra_carga" HeaderText="Detalle_otra_carga" SortExpression="Detalle_otra_carga"></asp:BoundField>
                                                        <asp:BoundField DataField="Porcent_iva" HeaderText="Porcent_iva" SortExpression="Porcent_iva"></asp:BoundField>

                                                        <asp:BoundField DataField="Total_iva" HeaderText="Total_iva" SortExpression="Total_iva" />
                                                        <asp:BoundField DataField="total_menos_iva" HeaderText="total_menos_iva" SortExpression="total_menos_iva" />
                                                        <asp:BoundField DataField="total_menos_otras_Iva" HeaderText="total_menos_otras_Iva" SortExpression="total_menos_otras_Iva" />
                                                        <asp:BoundField DataField="Nombre_pdf" HeaderText="Nombre_pdf" SortExpression="Nombre_pdf" />
                                                        <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
                                                    </Columns>
                                                    <EditRowStyle BorderStyle="None" HorizontalAlign="Center" VerticalAlign="Middle"></EditRowStyle>
                                                    <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <SelectedRowStyle BackColor="#CC6699" HorizontalAlign="Center" VerticalAlign="Middle" />
                                                </asp:GridView>

                                            </div>

                                        </div>
                                    </div>
                                </div>
                                <div class="tab-pane " id="link8">
                                    <div class="card">
                                        <div class="card-header">
                                            <h4 class="card-title">Location of the product</h4>
                                            <p class="card-category">
                                                More information here
                                            </p>
                                        </div>
                                        <div class="card-body">
                                            <div class="table-responsive">
                                                <asp:GridView runat="server" CssClass="table table-striped table-no-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id_ingreso_polli" DataSourceID="SqlDataPollinaza" EnablePersistedSelection="True" AllowPaging="True" AllowSorting="True">
                                                    <Columns>
                                                        <asp:CommandField ShowSelectButton="True" SelectText="	&lt;i style=&#39;color:orange&#39;class=&#39;fas fa-pen-square fa-2x&#39;&gt;&lt;/i&gt;"></asp:CommandField>
                                                        <asp:BoundField DataField="Id_ingreso_polli" HeaderText="Id_ingreso_polli" ReadOnly="True" InsertVisible="False" SortExpression="Id_ingreso_polli"></asp:BoundField>
                                                        <asp:BoundField DataField="Id_partida" HeaderText="Id_partida" SortExpression="Id_partida"></asp:BoundField>
                                                        <asp:BoundField DataField="Estado_pago" HeaderText="Estado_pago" SortExpression="Estado_pago"></asp:BoundField>
                                                        <asp:BoundField DataField="Plazo_pago" HeaderText="Plazo_pago" SortExpression="Plazo_pago"></asp:BoundField>
                                                        <asp:BoundField DataField="Numero_factura" HeaderText="Numero_factura" SortExpression="Numero_factura"></asp:BoundField>
                                                        <asp:BoundField DataField="Nombre_cliente" HeaderText="Nombre_cliente" SortExpression="Nombre_cliente"></asp:BoundField>
                                                        <asp:BoundField DataField="Fecha_emision" HeaderText="Fecha_emision" SortExpression="Fecha_emision"></asp:BoundField>

                                                        <asp:BoundField DataField="Cantidad_sacos" HeaderText="Cantidad_sacos" SortExpression="Cantidad_sacos" />
                                                        <asp:BoundField DataField="Precio_por_unidad" HeaderText="Precio_por_unidad" SortExpression="Precio_por_unidad" />
                                                        <asp:BoundField DataField="Total_pago" HeaderText="Total_pago" SortExpression="Total_pago" />
                                                        <asp:BoundField DataField="Nombre_pdf" HeaderText="Nombre_pdf" SortExpression="Nombre_pdf" />
                                                        <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                                                    </Columns>
                                                    <EditRowStyle BorderStyle="None" HorizontalAlign="Center" VerticalAlign="Middle"></EditRowStyle>
                                                    <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    <SelectedRowStyle BackColor="#CC6699" HorizontalAlign="Center" VerticalAlign="Middle" />
                                                </asp:GridView>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                               
                             
                            </div>
                        </div>
                    </div>
                </div>

                <%--FINAL DEL ROW--%>
                <asp:SqlDataSource ID="SqlDataAves" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT * FROM [tb_Ingreso_Aves_los_negritos]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataPollinaza" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT * FROM [tb_Ingreso_Pollinaza_los_negritos]"></asp:SqlDataSource>
            </div>
        </div>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand="SELECT [cedula_usuario], [nombre_usuario], [apellido1], [nick_name], [correo_electronico] FROM [tb_Usuarios_Los_negritos]"></asp:SqlDataSource>
    <!-- Logout Modal-->
    <%-- modal opcional para la gestion de ingresos --%>
    <div class="modal fade" id="logoutModalIngreso" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalRoles">Seleccione una opción.</h5>
                    <button class="close" type="button" data-dismiss="modal" aria-label="Cerrar">
                        <span aria-hidden="true">×</span>
                    </button>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="btnAves" class="btn btn-primary " runat="server" Text="Ingreso Aves " ForeColor="White" Width="200" UseSubmitBehavior="false" OnClick="btnAves_Click" />
                    <asp:Button ID="btnPollinaza" class="btn btn-primary " runat="server" Text="Ingreso Pollinaza" ForeColor="White" Width="200" UseSubmitBehavior="false" OnClick="btnPollinaza_Click" />
                </div>
            </div>
        </div>
    </div>
    <%-- fin de la modal --%>
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
</asp:Content>
