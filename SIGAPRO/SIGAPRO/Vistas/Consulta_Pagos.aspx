<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true"  EnableEventValidation="false" CodeBehind="Consulta_Pagos.aspx.cs" Inherits="SIGAPRO.Vistas.Consulta_Pagos" %>
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
                    <h4 class="card-title "> Consulta de Págos</h4>
                  </div>
                    <br />
                    <input id="Btndirije" type="button"  class="btn btn-primary col-md-3 ml-auto" value="+ PAGO" data-toggle="modal" data-target="#logoutModalxml" />
<%--                    <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="+ Pago" OnClick="Button1_Click" />--%>
                    <br />
                  <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                      <table class="table">
               
                        <tbody>

         <asp:gridview runat="server" cssclass="table table-striped table-no-bordered table-hover" autogeneratecolumns="False" datakeynames="cedula_usuario" datasourceid="SqlDataSource1" enablepersistedselection="True" AllowPaging="True">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="cedula_usuario" HeaderText="cedula_usuario" ReadOnly="True" SortExpression="cedula_usuario" />
            <asp:BoundField DataField="nombre_usuario" HeaderText="nombre_usuario" SortExpression="nombre_usuario" />
            <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
            <asp:BoundField DataField="nick_name" HeaderText="nick_name" SortExpression="nick_name" />
            <asp:BoundField DataField="correo_electronico" HeaderText="correo_electronico" SortExpression="correo_electronico" />
        </Columns>
    </asp:gridview>
                        </tbody>
                      </table>
                    </div>
                  </div>
                </div>
              </div>
            </div>       
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand="SELECT [cedula_usuario], [nombre_usuario], [apellido1], [nick_name], [correo_electronico] FROM [tb_Usuarios_Los_negritos]"></asp:SqlDataSource>
       <!-- Logout Modal-->
        <%-- modal opcional para la gestion de pagos --%>
        <div class="modal fade" id="logoutModalxml" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalRoles">Seleccione una opción.</h5>
                        <button class="close" type="button" data-dismiss="modal" aria-label="Cerrar">
                            <span aria-hidden="true">×</span>
                        </button>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnExtraccion" class="btn btn-primary " runat="server" Text="Extracción XML " ForeColor="White" Width="200"  UseSubmitBehavior ="false" OnClick="btnExtraccion_Click" />
                        <asp:Button ID="btnManual" class="btn btn-primary " runat="server" Text="Págo Manual"  ForeColor="White" Width="200"  UseSubmitBehavior ="false" OnClick="btnManual_Click" />
                    </div>
                </div>
            </div>
        </div>
        <%-- fin de la modal --%>

 
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
</asp:Content>
