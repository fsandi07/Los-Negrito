<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Registro_Empleados.aspx.cs" Inherits="SIGAPRO.Vistas.Registro_Empleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet"href="bower_components/chartist/dist/chartist.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-md-12">
              <div class="card ">
                <div class="card-header card-header-rose card-header-text">
                  <div class="card-text">
                    <h4 class="card-title">Registro de Colaborador</h4>
                  </div>
                </div>
                <div class="card-body ">
                  <form method="get" action="/" class="form-horizontal">
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Numero de identificación:</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                         <asp:TextBox ID="txt_identificacion" runat="server" class="form-control"></asp:TextBox><br />
                       <asp:Button ID="Btn_validar" runat="server" Text="Validar" class="btn btn-primary btn-sm" />
                          <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Nombre:</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                         <asp:TextBox ID="txt_Nombre" runat="server" class="form-control" ></asp:TextBox>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Primer Apellido:</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                         <asp:TextBox ID="txt_Apellido1" runat="server" class="form-control"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                     <div class="row">
                      <label class="col-sm-2 col-form-label">Segundo Apellido:</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                          <asp:TextBox ID="txt_Apellido2" runat="server" class="form-control"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Domicilio:</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                          <asp:TextBox ID="txt_Domicilio" runat="server" class="form-control"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                       <div class="row">
                      <label class="col-sm-2 col-form-label">Fecha de Nacimiento:</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                          <asp:Calendar ID="Calendar1" runat="server" CssClass="alert-dark"></asp:Calendar>
                        </div>
                      </div>
                    </div>
                     <div class="row">
                      <label class="col-sm-2 col-form-label">Número Telefonico:</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                         <asp:TextBox ID="txt_Numero_telefonico" runat="server" class="form-control" ></asp:TextBox>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Correo Electronico:</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                          <asp:TextBox ID="txt_Correo_Electronico" runat="server" class="form-control" ></asp:TextBox>
                        </div>
                      </div>
                    </div>
                          <div class="row">
                      <label class="col-sm-2 col-form-label">Cuenta IBAN:</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                          <asp:TextBox ID="txt_Cuenta_IBAN" runat="server" class="form-control" ></asp:TextBox>
                        </div>
                      </div>
                    </div>                         
                  </form>
                </div>
              </div>
            </div>
</asp:Content>
