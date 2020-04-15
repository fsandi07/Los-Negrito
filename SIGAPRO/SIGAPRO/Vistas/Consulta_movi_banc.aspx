<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Consulta_movi_banc.aspx.cs" Inherits="SIGAPRO.Vistas.Consulta_movi_banc" %>

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
                        <i class="material-icons">account_balance</i>
                    </div>
                    <h4 class="card-title ">Consulta de Movimientos Bancarios</h4>
                </div>
                <br />
                <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="+ Otro Movimiento" OnClick="Button1_Click" />
                <br />
                <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                        <table class="table">

                            <tbody>
                                <asp:GridView ID="Gridmovi" runat="server" CssClass="table table-striped table-no-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDatamovimiento" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="Gridmovi_SelectedIndexChanged" OnRowCommand="Gridmovi_RowCommand">
                                    <Columns>
                                        <asp:CommandField ShowSelectButton="True" HeaderText="Ver" SelectText=" &lt;i style=&#39;color:green&#39;class=&#39;fas fa-eye fa-2x&#39;&gt;&lt;/i&gt; "></asp:CommandField>
                                        <asp:ButtonField Text="&lt;i style=&#39;color:orange&#39;class=&#39;fas fa-pen-square fa-2x&#39;&gt;&lt;/i&gt;" CommandName="movi" HeaderText="+ Registro" />
                                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" InsertVisible="False" SortExpression="ID"></asp:BoundField>
                                        <asp:BoundField DataField="Banco" HeaderText="Banco" SortExpression="Banco"></asp:BoundField>
                                        <asp:BoundField DataField="Detalle" HeaderText="Detalle" SortExpression="Detalle"></asp:BoundField>
                                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha"></asp:BoundField>
                                        <asp:BoundField DataField="Nombre Movimiento" HeaderText="Nombre Movimiento" SortExpression="Nombre Movimiento"></asp:BoundField>
                                        <asp:BoundField DataField="Moneda" HeaderText="Moneda" SortExpression="Moneda"></asp:BoundField>
                                    </Columns>
                                    <EditRowStyle BorderStyle="None" HorizontalAlign="Center" VerticalAlign="Middle"></EditRowStyle>
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


    <asp:SqlDataSource ID="SqlDatamovimiento" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="select  a.id_registro_banco as [ID],b.nombre_banco as[Banco],a.detalle_movi as [Detalle],a.fecha_registro as [Fecha],
a.nombre_movi as [Nombre Movimiento],a.Moneda
from tb_regis_movi_ban_los_negritos a, tb_bancos_los_negritos b 
where a.id_banco = b.id_banco "></asp:SqlDataSource>   
    <%-- Modal para los Movimientos Creados --%>
    <div class="modal fade" id="ModalMovimientos" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabe2" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel2">Ingreso de Movimiento</h5>
                    <br />
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
                    <meta charset="utf-8">
                    <asp:Label ID="Lblid" class="col-sm-2 col-form-label" runat="server" Text="ID Caja" ForeColor="Red"></asp:Label>
                    <asp:Label ID="LblId_Caja" class="col-sm-2 col-form-label" runat="server" Text="Label" ForeColor="Red"></asp:Label><br />
                    <asp:Label ID="Label1" class="col-sm-2 col-form-label" runat="server" Text="Saldo Actual:" ForeColor="Red"></asp:Label>
                    <asp:Label ID="LblSaldo" class="col-sm-2 col-form-label" runat="server" Text="Label" ForeColor="Blue"></asp:Label><br />
                    <br />
                    <%-- inicio del formulario--%>

                    <div class="row">
                        <label class="col-sm-2 col-form-label">Tipo:</label><br />
                        <div class="col-sm-10">
                            <div class="form-group">
                                <asp:DropDownList ID="Dptmovi" runat="server" class="selectpicker" data-style="select-with-transition" >
                                    <asp:ListItem Value="Ingreso">Ingreso</asp:ListItem>
                                    <asp:ListItem Value="Egreso">Egreso</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                      <div class="row">
                        <label class="col-sm-2 col-form-label">Item:</label><br />
                        <div class="col-sm-10">
                            <div class="form-group">
                                <asp:DropDownList ID="DptItem" runat="server" class="selectpicker" data-style="select-with-transition">
                                    <asp:ListItem Value="N/A">N/A</asp:ListItem>
                                    <asp:ListItem Value="Si">Sí</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                     <div class="row">
                        <label class="col-sm-2 col-form-label">Fecha:</label>
                        <div class="col-sm-10">
                            <div class="form-group">
                                <input type="date" id="start" name="trip-start" onblur="registrofecha()"
                                    value="date.now();"
                                    min="2017-01-01" max="2030-12-31">
                                <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                            </div>
                        </div>
                    </div>
                     <div class="row">
                        <label class="col-sm-2 col-form-label">Detalle:</label>
                        <div class="col-sm-10">
                            <div class="form-group">
                                <asp:TextBox runat="server" ID="txt_detalle" class="form-control"></asp:TextBox>
                                <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-sm-2 col-form-label">Monto:</label>
                        <div class="col-sm-10">
                            <div class="form-group">
                                <asp:TextBox runat="server" ID="txtMontito" class="form-control"></asp:TextBox>
                                <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <label class="col-sm-2 col-form-label">N° Factura:</label>
                        <div class="col-sm-10">
                            <div class="form-group">
                                <asp:TextBox runat="server" ID="TxtNumFactura" class="form-control"></asp:TextBox>
                                <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                            </div>
                        </div>
                    </div>
                   



                    <%-- final del forumlario--%>
                    <div class="modal-footer">
                        <asp:Button ID="Button2" class="btn btn-primary " runat="server" Text="Registrar Datos" OnClick="Button2_Click" />

                    </div>
                </div>
            </div>
        </div>
    </div>
    <%-- fin de modal  --%>

    <asp:HiddenField ID="fecha" runat="server" />
    <asp:HiddenField ID="tipo_movi" runat="server" />


    <script type="text/javascript">       // mensaje de espera


        function registrofecha() {
            var Fecha_registro = document.getElementById("start").value;
            document.getElementById('<%=fecha.ClientID%>').value = Fecha_registro;
            var radiovalue = document.form1.RadioTipo_movi.value;
            document.getElementById('<%=tipo_movi.ClientID%>').value = radiovalue;

        }
    </script>

    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
    <script type="text/javascript">
        //Alerta para actualizar o ver detalles 
        function Actualizar() {
            Swal.fire({
                title: '¿Que Accion Desea Realizar?',
                text: "¡Por favor eliga una opccion!",
                type: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: '¡Modificar!',
                allowOutsideClick: false,
            }).then((result) => {
                if (result.value) {
                    window.setTimeout('location.href="modificar_pago.aspx"')
                    //Swal.fire({
                    //  //title: 'Borrado',
                    //  //text:'Tu Archivo se ha borrado.',
                    //  //type:'success',
                    //  //allowOutsideClick: false,

                    //})
                }
            })
        };

        function mensajeEspera() {
            let timerInterval
            Swal.fire({
                title: '¡Abriendo PDF!',

                timer: 5000,
                allowOutsideClick: false,
                onBeforeOpen: () => {

                    Swal.showLoading()

                    timerInterval = setInterval(() => {
                        Swal.getContent().querySelector('strong')
                            .textContent = (Swal.getTimerLeft() / 100)
                                .toFixed(0)
                    }, 100)
                },
                onClose: () => {
                    clearInterval(timerInterval)
                }

            })

            //window.setTimeout('location.href="Consultar_Pagos_Empleados.aspx"', 1000)

        }
        // mensaje de error
        function mensajeError() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + " Lo sentimos ha ocurrido un error, intente de nuevo" + "!",
                type: 'error',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 5000,

            })
        }
        //mensaje de conrfimacion
        function mensajeDeconfirmDelete() {
            swal.fire({
                title: "¡EXITO!",
                text: "¡" + "El Dato se Elimino Correctamente" + "!",
                type: 'success',
                allowOutsideClick: false,
            })
        }

        // mensaje de error
        function mensajeAviso() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + "Falta la fecha de ingresar" + "!",
                type: 'warning',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 5000,

            })
        }



    </script>
</asp:Content>
