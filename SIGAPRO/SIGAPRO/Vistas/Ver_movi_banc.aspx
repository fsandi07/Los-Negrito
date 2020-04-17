<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Ver_movi_banc.aspx.cs" Inherits="SIGAPRO.Vistas.Ver_movi_banc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content">
        <div class="col-md-12">
            <div class="card">
                <div class="card-header card-header-icon card-header-rose">
                    <div class="card-icon">
                        <i class="material-icons">account_balancey</i>
                    </div>
                    <h4 class="card-title ">Consulta de Movimientos Caja</h4>
                </div>
                <br />
                <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="Regresar" OnClick="Button1_Click"   />
                <br />
                <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                        <table class="table">
                           
                            <tbody>
                                <asp:GridView ID="GridMovi" runat="server" CssClass="table table-striped table-no-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDatamovibanc" AllowPaging="True" AllowSorting="True" OnRowDataBound="GridMovi_RowDataBound">
                                    <Columns>
                                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" InsertVisible="False" SortExpression="ID"></asp:BoundField>
                                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha"></asp:BoundField>
                                        <asp:BoundField DataField="Detalle" HeaderText="Detalle" SortExpression="Detalle"></asp:BoundField>
                                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad"></asp:BoundField>
                                        <asp:BoundField DataField="Saldo" HeaderText="Saldo" SortExpression="Saldo"></asp:BoundField>
                                        <asp:BoundField DataField="Item" HeaderText="Item" SortExpression="Item"></asp:BoundField>
                                        <asp:BoundField DataField="N&#176; Factura" HeaderText="N&#176; Factura" SortExpression="N&#176; Factura"></asp:BoundField>
                                        <asp:BoundField DataField="Nombre Movimiento" HeaderText="Nombre Movimiento" SortExpression="Nombre Movimiento"></asp:BoundField>
                                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo"></asp:BoundField>
                                    </Columns>
                                     <EditRowStyle BorderStyle="None" HorizontalAlign="Center" VerticalAlign="Middle"></EditRowStyle>
                                    <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <SelectedRowStyle  HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:GridView>
                            </tbody>
                        </table>
                    </div>
                </div>
                <br />
                <asp:Label ID="Lbtitulo" runat="server" Text="SALDO EN BANCO:"  class="col-sm-2 col-form-label"></asp:Label>
                 <asp:Label ID="LblSaldo" runat="server" Text=""  class="col-sm-2 col-form-label" ForeColor="#000066" Font-Bold="True"></asp:Label>
            </div>
        </div>
    </div>
    <asp:SqlDataSource ID="SqlDatamovibanc" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="select a.Id_registro as [ID],a.fecha as [Fecha],a.detalle as [Detalle],a.cantidad as [Cantidad],a.saldo as [Saldo],a.item as [Item],
a.num_factura as [N° Factura],b.nombre_movi as [Nombre Movimiento],a.tipo_movi as [Tipo]
from tb_ingreso_regist_mov_banc_los_negritos a,tb_regis_movi_ban_los_negritos b 
where a.id_movi_banc = b.id_registro_banco"></asp:SqlDataSource>

    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
</asp:Content>
