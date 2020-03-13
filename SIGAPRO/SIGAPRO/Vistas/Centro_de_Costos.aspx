<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Centro_de_Costos.aspx.cs" Inherits="SIGAPRO.Vistas.Centro_de_Costos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <br>
   <br /> 
    <div class="col-md-12">
              <div class="card ">
                <div class="card-header card-header-rose card-header-text">
                  <div class="card-text">
                    <h4 class="card-title">Agregar un Centro de Costos</h4>
                  </div>
                </div>
                <div class="card-body ">
                  <form method="get" action="/" class="form-horizontal">
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Numero de Centro de Costos</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                            <asp:textbox runat="server" ID="txt_centro_de_costos"  class="form-control"></asp:textbox>
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
