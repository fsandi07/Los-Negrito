<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Conusltar_partidas.aspx.cs" Inherits="SIGAPRO.Vistas.Conusltar_partidas" ValidateRequest="false" EnableEventValidation="false" %>

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
                        <i class="material-icons">group</i>
                    </div>
                    <h4 class="card-title ">Consulta Partidas</h4>
                </div>
                <br />
                <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="+ PARTIDA" OnClick="Btn_redirije_Click" />
                <br />
                <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                        <table class="table">

                            <tbody>
                                <asp:GridView ID="Grid_Partidas" CssClass="table table-striped table-no-bordered table-hover" runat="server" DataSourceID="SQLdataPartida" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="Grid_Partidas_SelectedIndexChanged">
                                    <Columns>
                                        <asp:CommandField ShowSelectButton="True" HeaderText="Editar" SelectText="&lt;i style=&#39;color:orange&#39;class=&#39;fas fa-pen-square fa-2x&#39;&gt;&lt;/i&gt;"></asp:CommandField>
                                    </Columns>
                                    <EditRowStyle BorderStyle="None" HorizontalAlign="Center" VerticalAlign="Middle"></EditRowStyle>
                                    <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <SelectedRowStyle BackColor="#CC6699" HorizontalAlign="Center" VerticalAlign="Middle" />

                                </asp:GridView>

                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand="SELECT [cedula_usuario], [nombre_usuario], [apellido1], [nick_name], [correo_electronico] FROM [tb_Usuarios_Los_negritos]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SQLdataPartida" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand="select numero_partida as [Numero Partida], descripcion as [Descripción Partida],
fecha_inicio as [Fecha Inicio], fecha_finla as [Fecha Final], estado as [Estado] from tb_Partidas_Los_Negritos"></asp:SqlDataSource>
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
    <%--Modal para cargar los datos que se van a actualizar --%>
    <div class="modal fade" id="Modal_Partidas" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">¿Desea Modificar esta Partida?</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="card-body ">

                        <div class="row">
                            <label class="col-sm-2 col-form-label">Numero de Partida</label>
                            <div class="col-sm-10">
                                <div class="form-group">
                                    <asp:TextBox runat="server" ID="txt_numero_partida" class="form-control" ReadOnly="true"></asp:TextBox>
                                    <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <label class="col-sm-2 col-form-label">Descripcion</label>
                            <div class="col-sm-10">
                                <div class="form-group">
                                    <asp:TextBox ID="txt_descripcion" runat="server" class="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <label class="col-sm-2 col-form-label">Rango de Fecha:</label>
                        <div class="row">
                            <div class="col-md-6 ml-auto mr-auto">
                                <div class="card">
                                    <div class="row">
                                        <label class="col-sm-2 col-form-label">Inicio:</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">
                                                <div class="row">
                                                    <div class="col-sm-10">
                                                        <asp:TextBox ID="txt_fecha_inicio" runat="server"></asp:TextBox>
                                                        <input class="glyphicon glyphicon-calendar" type="date" id="start1" name="trip-start"
                                                            value="date.now();"
                                                            min="01-01-2017" max="31-12-2030" required>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6 ml-auto mr-auto">
                                <div class="card">
                                    <div class="row">
                                        <label class="col-sm-2 col-form-label">Final:</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">
                                                <div class="row">
                                                    <div class="col-sm-10">
                                                        <asp:TextBox ID="txt_fecha_final" runat="server"></asp:TextBox>
                                                        <input class="glyphicon glyphicon-calendar" type="date" id="start" name="trip-start" onblur="registro()"
                                                            value="date.now();"
                                                            min="01-01-2017" max="31-12-2030" required>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                    Estado:
                    <asp:DropDownList ID="dptestado" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="selecione el estado">
                        <asp:ListItem Value="Activo">Activo</asp:ListItem>
                        <asp:ListItem Value="Inactivo">Inactivo</asp:ListItem>
                    </asp:DropDownList>
                    <div class="modal-footer">
                        <%--  --%>
                        <asp:Button ID="btn_modificar" runat="server" Text="Modificar" class="btn btn-success" OnClick="btn_modificar_Click" />
                         <button type="button"  class="btn btn-danger" data-dismiss="modal">Cancelar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
     <asp:HiddenField ID="fechainicio" runat="server" />
    <asp:HiddenField ID="fechafinal" runat="server" />
    <script type="text/javascript"> 
        function mensajeDeconfirmacion() {
            swal.fire({
                title: "¡EXITO!",
                text: "¡" + "Los Datos se Modificaron Con Exito" + "!",
                type: 'success',
                allowOutsideClick: false,
            }).then((result) => {
                if (result.value) {
                    window.setTimeout('location.href="Conusltar_partidas.aspx"')

                }
            })
        }
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

        function registro() {
            var fechainicio = document.getElementById("start1").value;
            var fechafinal = document.getElementById("start").value;
            document.getElementById('<%=fechainicio.ClientID%>').value = fechainicio;
             document.getElementById('<%=fechafinal.ClientID%>').value = fechafinal;
        }
    </script>
</asp:Content>
