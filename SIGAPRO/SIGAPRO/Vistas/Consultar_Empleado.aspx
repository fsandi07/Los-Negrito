<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Consultar_Empleado.aspx.cs" Inherits="SIGAPRO.Vistas.Consultar_Empleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content">   
              <div class="col-md-12">
                <div class="card">
                  <div class="card-header card-header-icon card-header-rose">
                    <div class="card-icon">
                      <i class="material-icons">group</i>
                    </div>
                    <h4 class="card-title "> Consulta de Colaborador</h4>
                  </div>                    
                    <asp:Button ID="Btnredirije"  class="btn btn-primary col-md-3 ml-auto" runat="server" Text="+ COLABORADOR" OnClick="Btnredirije_Click" />
                  <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                      <table class="table">                     
                        <tbody>

                          <asp:GridView ID="Gridempleado" CssClass="table table-striped table-no-bordered table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="Cédula" DataSourceID="SqlDataempleado" AllowPaging="True" AllowSorting="True">
                              <Columns>
                                  <asp:CommandField ShowSelectButton="True" HeaderText="Editar"></asp:CommandField>
                                  <asp:BoundField DataField="C&#233;dula" HeaderText="C&#233;dula" ReadOnly="True" SortExpression="C&#233;dula"></asp:BoundField>
                                  <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
                                  <asp:BoundField DataField="1 Apellido" HeaderText="1 Apellido" SortExpression="1 Apellido"></asp:BoundField>
                                  <asp:BoundField DataField="2 Apellido" HeaderText="2 Apellido" SortExpression="2 Apellido"></asp:BoundField>
                                  <asp:BoundField DataField="Domicilio" HeaderText="Domicilio" SortExpression="Domicilio"></asp:BoundField>
                                  <asp:BoundField DataField="Tel&#233;fono" HeaderText="Tel&#233;fono" SortExpression="Tel&#233;fono"></asp:BoundField>
                                  <asp:BoundField DataField="Correo El&#233;ctronico" HeaderText="Correo El&#233;ctronico" SortExpression="Correo El&#233;ctronico"></asp:BoundField>
                                  <asp:BoundField DataField="Fecha Nacimiento" HeaderText="Fecha Nacimiento" SortExpression="Fecha Nacimiento"></asp:BoundField>
                                  <asp:BoundField DataField="Inicio Trabajo" HeaderText="Inicio Trabajo" SortExpression="Inicio Trabajo"></asp:BoundField>
                                  <asp:BoundField DataField="IBAN" HeaderText="IBAN" SortExpression="IBAN"></asp:BoundField>
                                  <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado"></asp:BoundField>
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
    <asp:SqlDataSource ID="SqlDataempleado" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="
select numero_cedula as [Cédula], nombre as [Nombre], apellido1 as [1 Apellido], apellido2 [2 Apellido],
domicilio as [Domicilio], numero_telefono [Teléfono], correo as [Correo Eléctronico], fecha_nacimiento as [Fecha Nacimiento],
fecha_inicio as [Inicio Trabajo], numero_cuenta as [IBAN], estado_empleado as [Estado]   from tb_empleado_los_negritos"></asp:SqlDataSource>
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
</asp:Content>
