<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Consultar_centro_costos.aspx.cs" Inherits="SIGAPRO.Vistas.Consultar_centro_costos" %>

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
                    <h4 class="card-title ">Consulta de Centro de Costos</h4>
                </div>
                <br />
                <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="+ CENTRO COSTOS" OnClick="Btn_redirije_Click" />
                <br />
                <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                        <table class="table">                            
                            <tbody>
                               
                            </tbody>
                        </table>
                        <asp:GridView runat="server" CssClass="table table-striped table-no-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Centro de Costos" DataSourceID="SqlDataSource2" EnablePersistedSelection="True" AllowPaging="True" EditRowStyle-BorderStyle="None" AllowSorting="True" HorizontalAlign="Center">
                            <AlternatingRowStyle HorizontalAlign="Center" VerticalAlign="Top" />
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" HeaderText="Editar" />
                                <asp:BoundField DataField="Centro de Costos" HeaderText="Centro de Costos" ReadOnly="True" SortExpression="Centro de Costos"></asp:BoundField>
                                <asp:BoundField DataField="Descripci&#243;n" HeaderText="Descripci&#243;n" SortExpression="Descripci&#243;n" />
                                <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                                    </Columns>

                                    <EditRowStyle BorderStyle="None" HorizontalAlign="Center" VerticalAlign="Middle"></EditRowStyle>
                                    <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <SelectedRowStyle BackColor="#CC6699" HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand=" select numero_centro_costos as [Centro de Costos],descripcion as [Descripción], estado as [Estado] from tb_centro_de_costos_los_negritos"></asp:SqlDataSource>
</asp:Content>
