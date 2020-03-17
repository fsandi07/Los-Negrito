<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Conusltar_partidas.aspx.cs" Inherits="SIGAPRO.Vistas.Conusltar_partidas" %>
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
                    <h4 class="card-title "> Consulta Partidas</h4>
                  </div>
                    <br />
                    <br />
                  <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                      <table class="table">
                        <thead class="">
                          <th class="auto-style4">
                            ID
                          </th>
                          <th class="auto-style1">                                                   
                            Name
                          </th>
                          <th class="auto-style2">
                            Country
                          </th>
                          <th class="auto-style5">
                            City
                          </th>
                          <th>
                            Salary
                          </th>
                        </thead>
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
   <br />
    <div class="row">
                <div class="col-md-6 ml-auto mr-auto">
                  <div class="card">
                    <div class="card-body text-center">
                        <code>Agregar nueva Partida?</code><br />
                       <asp:Button class="btn btn-primary" ID="Btn_redirije" runat="server" Text="Nuevo Partida" OnClick="Btn_redirije_Click" />
                    </div>
                  </div>
                </div>
              </div>
      
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
</asp:Content>
