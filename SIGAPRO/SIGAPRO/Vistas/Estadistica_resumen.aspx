<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Estadistica_resumen.aspx.cs" Inherits="SIGAPRO.Vistas.Estadistica_resumen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content">
        <div class="col-md-12">
            <div class="card">
                <div class="card-header card-header-icon card-header-rose">
                    <div class="card-icon">
                        <i class="material-icons">account_balance</i>
                    </div>
                    <h4 class="card-title ">Consulta de Bancos</h4>
                </div>
                <br />
                <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="+ "  />
                <br />
                <div class="col-md-3">
                        <div class="form-group">
                          <label class="bmd-label-floating">Año</label>
                          <asp:DropDownList ID="Dptyear" runat="server" class="selectpicker" data-style="select-with-transition" AutoPostBack="True">
                                                <asp:ListItem Value="2025">2025</asp:ListItem>
                                                <asp:ListItem Value="2024">2024</asp:ListItem>
                                                <asp:ListItem Value="2023">2023</asp:ListItem>
                                                <asp:ListItem Value="2022">2022</asp:ListItem>
                                                <asp:ListItem Value="2021">2021</asp:ListItem>
                                                <asp:ListItem Value="2020">2020</asp:ListItem>
                                                <asp:ListItem Value="2019">2019</asp:ListItem>
                                                <asp:ListItem Value="2018">2018</asp:ListItem>
                                            </asp:DropDownList>
                        </div>
                      </div>
                <br />
                Totales por Partidas (Subtotal)
                <div class="card-body table-full-width table-hover">                       
                    <div class="table-responsive">
                        <table class="table">
                           
                            <tbody>
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDatatotalparti" CssClass="table table-striped table-no-bordered table-hover">
                                    <Columns>
                                        <asp:BoundField DataField="Partida" HeaderText="Partida" SortExpression="Partida"></asp:BoundField>
                                        <asp:BoundField DataField="Total x Partida" HeaderText="Total x Partida" SortExpression="Total x Partida" ReadOnly="True"></asp:BoundField>
                                    </Columns>
                                </asp:GridView>
                            </tbody>
                        </table>
                    </div>
                    <asp:SqlDataSource ID="SqlDatatotalparti" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="select Id_Partida_Control as [Partida],sum(Total) as [Total x Partida]  from  tb_control_gastos_los_negritos 
where Periodo =@periodo  group by Id_Partida_Control,Periodo ">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="Dptyear" PropertyName="SelectedValue" DefaultValue="2020" Name="periodo"></asp:ControlParameter>
                                 </SelectParameters>
                             </asp:SqlDataSource>
                </div>
                    Totales por centro de costos y partidas(Total de cada partida por cada centro de costo)
                <div class="card-body table-full-width table-hover">                       
                    <div class="table-responsive">
                        <table class="table">
                           
                            <tbody>
                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CssClass="table table-striped table-no-bordered table-hover">
                                    <Columns>
                                        <asp:BoundField DataField="Centro Costos" HeaderText="Centro Costos" SortExpression="Centro Costos"></asp:BoundField>
                                        <asp:BoundField DataField="Partida" HeaderText="Partida" SortExpression="Partida"></asp:BoundField>
                                        <asp:BoundField DataField="Total" HeaderText="Total" ReadOnly="True" SortExpression="Total"></asp:BoundField>
                                    </Columns>
                                </asp:GridView>
                            </tbody>
                        </table>
                    </div>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="select Id_Centro_costos as [Centro Costos],Id_Partida_Control as [Partida],sum(Total) as [Total]  from  tb_control_gastos_los_negritos 
where Periodo =@periodo  group by Id_Centro_costos, Id_Partida_Control,Periodo ">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="Dptyear" PropertyName="SelectedValue" DefaultValue="2020" Name="periodo"></asp:ControlParameter>
                                 </SelectParameters>
                             </asp:SqlDataSource>
                </div>


            </div>
        </div>
    </div>


    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
</asp:Content>
