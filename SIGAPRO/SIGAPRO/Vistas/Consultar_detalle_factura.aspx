<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Consultar_detalle_factura.aspx.cs" Inherits="SIGAPRO.Vistas.Consultar_detalle_factura" %>
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
                    <h4 class="card-title "> Consulta de Clasificacion Factura</h4>
                  </div>
                    <br />
                    <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="+ DETALLE" OnClick="Btn_redirije_Click" />
                    <br />
                  <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                      <table class="table">
                        <tbody>

                            <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-no-bordered table-hover" DataSourceID="SqlDataSource2" AllowPaging="True" AllowSorting="True" HorizontalAlign="Center" EditRowStyle-HorizontalAlign="Center" EditRowStyle-VerticalAlign="Middle" EmptyDataRowStyle-HorizontalAlign="Center" EmptyDataRowStyle-VerticalAlign="Middle" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" RowStyle-HorizontalAlign="Center" RowStyle-VerticalAlign="Middle" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" HeaderText="Editar" />
                                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" InsertVisible="False" SortExpression="ID"></asp:BoundField>
                                    <asp:BoundField DataField="Nombre Clasificacion" HeaderText="Nombre Clasificacion" SortExpression="Nombre Clasificacion"></asp:BoundField>
                                    <asp:BoundField DataField="Descripci&#243;n" HeaderText="Descripci&#243;n" SortExpression="Descripci&#243;n"></asp:BoundField>
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado"></asp:BoundField>

                                </Columns>
                                <SelectedRowStyle BackColor="#CC6699" HorizontalAlign="Center" VerticalAlign="Middle" />
                              </asp:GridView>

                        </tbody>
                      </table>

         
                    </div>
                  </div>
                </div>
              </div>
            </div>
       
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand=" select id_detalle as[ID],nombre_detalle as [Nombre Clasificacion], descripcion_detalle as [Descripción], estado_detalle as [Estado] from tb_Detalle_Factura_los_negritos"></asp:SqlDataSource>
    
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
</asp:Content>
