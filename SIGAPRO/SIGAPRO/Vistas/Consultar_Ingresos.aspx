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
              <input id="Btndirije" type="button"  class="btn btn-primary col-md-3 ml-auto" value="+ INGRESO" data-toggle="modal" data-target="#logoutModalIngreso" />
                <br />
                <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                        <table class="table">
                            <thead class="">
                                <th class="auto-style4">ID
                                </th>
                                <th class="auto-style1">Name
                                </th>
                                <th class="auto-style2">Country
                                </th>
                                <th class="auto-style5">City
                                </th>
                                <th>Salary
                                </th>
                            </thead>
                            <tbody>
                                <asp:GridView runat="server" CssClass="table table-striped table-no-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="cedula_usuario" DataSourceID="SqlDataSource1" EnablePersistedSelection="True" AllowPaging="True">
                                    <Columns>
                                        <asp:CommandField ShowSelectButton="True" />
                                        <asp:BoundField DataField="cedula_usuario" HeaderText="cedula_usuario" ReadOnly="True" SortExpression="cedula_usuario" />
                                        <asp:BoundField DataField="nombre_usuario" HeaderText="nombre_usuario" SortExpression="nombre_usuario" />
                                        <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
                                        <asp:BoundField DataField="nick_name" HeaderText="nick_name" SortExpression="nick_name" />
                                        <asp:BoundField DataField="correo_electronico" HeaderText="correo_electronico" SortExpression="correo_electronico" />
                                    </Columns>
                                </asp:GridView>
                            </tbody>
                        </table>
                    </div>
                </div>
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
                        <asp:Button ID="btnAves" class="btn btn-primary " runat="server" Text="Ingreso Aves " ForeColor="White" Width="200"  UseSubmitBehavior ="false" OnClick="btnAves_Click" />
                        <asp:Button ID="btnPollinaza" class="btn btn-primary " runat="server" Text="Ingreso Pollinaza"  ForeColor="White" Width="200"  UseSubmitBehavior ="false" OnClick="btnPollinaza_Click" />
                    </div>
                </div>
            </div>
        </div>
        <%-- fin de la modal --%>
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
</asp:Content>
