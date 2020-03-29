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
                    <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="+ PARTIDA" OnClick="Btn_redirije_Click" />
                    <br />
                  <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                      <table class="table">
                       
                        <tbody>
                            <asp:GridView ID="GridViewPartidas" CssClass="table table-striped table-no-bordered table-hover" runat="server" DataSourceID="SQLdataPartida" AllowPaging="True" AllowSorting="True">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" HeaderText="Editar" ></asp:CommandField>
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
    <asp:SqlDataSource ID="SQLdataPartida" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand="select numero_partida as [Numero Partida], descripcion as [Descripción Partida],
fecha_inicio as [Fecha Inicio], fecha_finla as [Fecha Final], estado as [Estado] from tb_Partidas_Los_Negritos"></asp:SqlDataSource>
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
</asp:Content>
