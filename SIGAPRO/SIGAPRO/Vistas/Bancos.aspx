<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Bancos.aspx.cs" Inherits="SIGAPRO.Vistas.Bancos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <br>
   <br /> 
    <div class="col-md-12">
              <div class="card ">
                <div class="card-header card-header-rose card-header-text">
                  <div class="card-text">
                    <h4 class="card-title">Agregar un Banco</h4>
                  </div>
                </div>
                <div class="card-body ">
                  <form method="get" action="/" class="form-horizontal">
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Nombre del Banco</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                            <asp:textbox runat="server" ID="txt_nombre_banco"  class="form-control"></asp:textbox>
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
                      <label class="col-sm-2 col-form-label">Cuenta iban</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                         <asp:TextBox ID="txt_cuenta_iban" runat="server" class="form-control"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                   </form>
                </div>
              </div>
            </div>

</asp:Content>
