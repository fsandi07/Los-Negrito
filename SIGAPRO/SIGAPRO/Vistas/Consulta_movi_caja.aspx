<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Consulta_movi_caja.aspx.cs" Inherits="SIGAPRO.Vistas.Consulta_movi_caja" %>
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
                        <i class="material-icons">attach_money</i>
                    </div>
                    <h4 class="card-title ">Consulta de Movimientos Caja</h4>
                </div>
                <br />
                <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="Regresar" O OnClick="Button1_Click1"  />
                <br />
                <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                        <table class="table">
                           
                            <tbody>
                                <asp:GridView ID="GridMovimientos" CssClass="table table-striped table-no-bordered table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_movimiento" DataSourceID="SqlDataMovimiento" AllowPaging="True" AllowSorting="True" OnRowDataBound="GridMovimientos_RowDataBound">
                        <Columns>                           
                            <asp:BoundField DataField="Id_movimiento" HeaderText="Id movimiento" ReadOnly="True" InsertVisible="False" SortExpression="Id_movimiento"></asp:BoundField>
                            <asp:BoundField DataField="Detalle" HeaderText="Detalle" SortExpression="Detalle"></asp:BoundField>
                            <asp:BoundField DataField="Fecha_movi" HeaderText="Fecha" SortExpression="Fecha_movi"></asp:BoundField>
                            <asp:BoundField DataField="Movimiento" HeaderText="Movimiento" SortExpression="Movimiento"></asp:BoundField>
                            <asp:BoundField DataField="Saldo" HeaderText="Saldo" SortExpression="Saldo"></asp:BoundField>
                            <asp:BoundField DataField="Tipo_movi" HeaderText="Movimiento" SortExpression="Tipo_movi"></asp:BoundField>
                            <asp:BoundField DataField="Id_caja" HeaderText="Id caja" SortExpression="Id_caja"></asp:BoundField>
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
                <br />
                <asp:Label ID="Lbtitulo" runat="server" Text="SALDO EN CAJA:"  class="col-sm-2 col-form-label"></asp:Label>
                 <asp:Label ID="LblSaldo" runat="server" Text=""  class="col-sm-2 col-form-label" ForeColor="#000066" Font-Bold="True"></asp:Label>
            </div>
        </div>
    </div>
      <asp:SqlDataSource ID="SqlDataMovimiento" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT * FROM [tb_Caja_Movi_los_negritos]"></asp:SqlDataSource>
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
</asp:Content>


