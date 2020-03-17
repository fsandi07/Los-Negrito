<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Ingresar_detalle_Facturas.aspx.cs" Inherits="SIGAPRO.Vistas.Ingresar_detalle_Facturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="bower_components/chartist/dist/chartist.min.css">
    <%-- links para las alertas  --%>
    <script type="text/javascript" src="jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="sweetalert/sweetalert2.min.css">
    <script type="text/javascript" src="sweetalert/sweetalert2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-md-12">
              <div class="card ">
                <div class="card-header card-header-rose card-header-text">
                  <div class="card-text">
                    <h4 class="card-title">Agregar detalle para facturas</h4>
                  </div>
                </div>
                <div class="card-body ">                 
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Nombre del detalle</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                            <asp:textbox runat="server" ID="txt_nombre_detalle"  class="form-control"></asp:textbox>
                          <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Descripcion</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                         <asp:TextBox ID="txt_descripcion_detalle" runat="server" class="form-control"></asp:TextBox>
                        </div>
                      </div>
                    </div>                                        
                </div>
              </div>
            </div>
</asp:Content>
