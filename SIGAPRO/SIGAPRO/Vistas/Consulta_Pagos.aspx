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
                <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                        <table class="table">

                            <tbody>
                                <asp:GridView ID="GridVegreso" runat="server" CssClass="table table-striped table-no-bordered" DataSourceID="SqlDataEgreso2" AllowPaging="True" AllowSorting="True" OnRowDataBound="GridVegreso_RowDataBound">
                                    <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Top" />
                                    <Columns>
                                        <asp:CommandField ShowSelectButton="True" HeaderText="Editar" SelectText="&lt;i style=&#39;color:orange&#39;class=&#39;fas fa-pen-square fa-2x&#39;&gt;&lt;/i&gt;" />
                                        <asp:BoundField HeaderText="Advertencia"></asp:BoundField>
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

        <asp:SqlDataSource ID="SqlDataegreso" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [Digital], [Fecha_ingreso], [Numero_factura], [Cedula_Juridica], [GTI], [Nombre_comercio], [Monto_factura], [Estado_pago], [Plazo_pago], [Moneda], [Tipo_cambio], [Mes], [TotalIva], [Estado] FROM [tb_Egreso_Manual_los_negritos]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataEgreso2" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT * FROM [tb_Egreso_Manual_los_negritos]"></asp:SqlDataSource>
        <!-- Logout Modal-->
    </div>
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
    </script>
</asp:Content>
