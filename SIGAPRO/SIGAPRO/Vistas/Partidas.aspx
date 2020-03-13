<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Partidas.aspx.cs" Inherits="SIGAPRO.Vistas.Partidas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <link rel="stylesheet"href="bower_components/chartist/dist/chartist.min.css">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
   <br /> 
    <div class="col-md-12">
              <div class="card ">
                <div class="card-header card-header-rose card-header-text">
                  <div class="card-text">
                    <h4 class="card-title">Agregar una nueva Partida</h4>
                  </div>
                </div>
                <div class="card-body ">
                  <form method="get" action="/" class="form-horizontal">
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Numero de Partida</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                            <asp:textbox runat="server" ID="txt_numero_partida" TextMode="Number" class="form-control"></asp:textbox>
                          <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Descripcion</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                         <asp:TextBox ID="txt_descripcion" runat="server" class="form-control"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Fecha de inicio</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                      <div class="tab-pane active" id="link2">
                                    Selecione un mes de inicio.
                                     <br />
                                    <br />
                                    <div class="col-lg-5 col-md-6 col-sm-3">
                                        <asp:DropDownList ID="Dpt_fecha_inicio" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Selecionar fecha de Inicio">
                                            <asp:ListItem Value="Enero">Enero</asp:ListItem>
                                            <asp:ListItem Value="Febrero">Febrero</asp:ListItem>
                                            <asp:ListItem Value="Marzo">Marzo </asp:ListItem>
                                             <asp:ListItem Value="Abril">Abril </asp:ListItem>
                                             <asp:ListItem Value="Mayo">Mayo </asp:ListItem>
                                             <asp:ListItem Value="Junio">Junio </asp:ListItem>
                                             <asp:ListItem Value="Julio">Julio </asp:ListItem>
                                             <asp:ListItem Value="Agosto">Agosto</asp:ListItem>
                                             <asp:ListItem Value="Septiembre">Septiembre</asp:ListItem>
                                             <asp:ListItem Value="Octubre">Octubre</asp:ListItem>
                                             <asp:ListItem Value="Noviembre">Noviembre</asp:ListItem>
                                             <asp:ListItem Value="Diciembre">Diciembre</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>

                                    <br />
                                </div>
                        </div>
                      </div>
                    </div>
                     <div class="row">
                      <label class="col-sm-2 col-form-label">Fecha final</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                                <div class="tab-pane active" id="link3">
                                    Seleccione el Centro de Costos.
                                     <br />
                                    <br />
                                    <div class="col-lg-5 col-md-6 col-sm-3">
                                        <asp:DropDownList ID="Dpt_fecha_final" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar Fecha Final">
                                          <asp:ListItem Value="Enero">Enero</asp:ListItem>
                                            <asp:ListItem Value="Febrero">Febrero</asp:ListItem>
                                            <asp:ListItem Value="Marzo">Marzo </asp:ListItem>
                                             <asp:ListItem Value="Abril">Abril </asp:ListItem>
                                             <asp:ListItem Value="Mayo">Mayo </asp:ListItem>
                                             <asp:ListItem Value="Junio">Junio </asp:ListItem>
                                             <asp:ListItem Value="Julio">Julio </asp:ListItem>
                                             <asp:ListItem Value="Agosto">Agosto</asp:ListItem>
                                             <asp:ListItem Value="Septiembre">Septiembre</asp:ListItem>
                                             <asp:ListItem Value="Octubre">Octubre</asp:ListItem>
                                             <asp:ListItem Value="Noviembre">Noviembre</asp:ListItem>
                                             <asp:ListItem Value="Diciembre">Diciembre</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <br />
                                    <br />
                                </div>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Numero de Factura</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                                  <div class="tab-pane active" id="link1">
                                   Seleccione un numero de Factura.
                                     <br />
                                    <br />
                                    <div class="col-lg-5 col-md-6 col-sm-3">
                                        <asp:dropdownlist runat="server" DataSourceID="SqlDataNumero_Facturas" DataTextField="numero_factura" DataValueField="numero_factura"  class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar Numero de Factura">

                                        </asp:dropdownlist>
                                        <asp:SqlDataSource ID="SqlDataNumero_Facturas" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand="SELECT [numero_factura] FROM [Los_negritos_Extraccion_DE_Datos]"></asp:SqlDataSource>
                                    </div>

                                    <br />
                                    <div>
                                    </div>
                                    <br />
                        
                                </div>
                        </div>
                      </div>
                    </div>

                  </form>
                </div>
              </div>
            </div>

</asp:Content>
