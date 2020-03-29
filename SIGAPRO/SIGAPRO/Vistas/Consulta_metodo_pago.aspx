<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Consulta_metodo_pago.aspx.cs" Inherits="SIGAPRO.Vistas.Consulta_metodo_pago" %>
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
                      <i class="material-icons">local_atm</i>
                    </div>
                    <h4 class="card-title "> Consulta de Método Págo</h4>
                  </div>
                    <br />
                    <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="+ Método" OnClick="Button1_Click" />
                    <br />
                  <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                      <table class="table">
                        
                        <tbody>

                            <asp:GridView ID="GridMetodoPago" CssClass="table table-striped table-no-bordered table-hover"  runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataMetodo" AllowPaging="True" AllowSorting="True">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" HeaderText="Editar"></asp:CommandField>
                                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" InsertVisible="False" SortExpression="ID"></asp:BoundField>
                                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
                                    <asp:BoundField DataField="Descripci&#243;n" HeaderText="Descripci&#243;n" SortExpression="Descripci&#243;n"></asp:BoundField>
                                    <asp:BoundField DataField="Numero Referencia" HeaderText="Numero Referencia" SortExpression="Numero Referencia"></asp:BoundField>
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
    <asp:SqlDataSource ID="SqlDataMetodo" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="select iD_Metodo as [ID], Nombre,Descripcion as [Descripción], Num_refe as [Numero Referencia], estado as [Estado] from tb_metodo_Pago_los_negritos "></asp:SqlDataSource>
    
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
</asp:Content>
