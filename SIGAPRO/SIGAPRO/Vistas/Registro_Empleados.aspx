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
                                        <div class="col-sm-10"> <br />                                         
                                            <input type="date" id="start" name="trip-start"
                                                value=date.now();
                                                min="1960-01-01" max="2020-12-31">
                                        </div>
                                    </div>
                      <div class="row">
                                        <label class="col-sm-2 col-form-label">Fecha de Inicio Trabajar:</label>
                                        <div class="col-sm-10"> <br />                                         
                                            <input type="date" id="start1" name="trip-start"
                                                value=date.now();
                                                min="2010-01-01" max="2030-12-31" onblur="verificarDato()">
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
                          <asp:TextBox ID="txt_Correo_Electronico" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
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
    <div class="row">
                <div class="col-md-6 ml-auto mr-auto">
                  <div class="card">
                    <div class="card-body text-center">                        
                      <asp:Button class="btn btn-success" ID="btn_registra" runat="server" Text="Registrar Colaborador" Width="210px" OnClick="btn_registra_Click" />
                    </div>
                  </div>
                </div>
              </div>
     <asp:HiddenField ID="fecha_nacimiento" runat="server" />
    <asp:HiddenField ID="fecha_ingreso" runat="server" />

      <script type="text/javascript"> 

          function verificarDato() {

              //alert('ha cargado la ventanaJAO');          
              var Fecha = document.getElementById("start").value;
            document.getElementById('<%=fecha_nacimiento.ClientID%>').value =
                Fecha;
              var Fecha_ingreso = document.getElementById("start1").value;
              document.getElementById('<%=fecha_ingreso.ClientID%>').value =
                  Fecha_ingreso;
          }
          //mensaje de conrfimacion
          function mensajeDeconfirmacion() {
              swal.fire({
                  title: "¡EXITO!",
                  text: "¡" + "Los Datos se Guardaron Con Exito" + "!",
                  type: 'success',
                  allowOutsideClick: false,
              })
          }
          // mensaje de error
          function mensajeError() {
              swal.fire({
                  title: '¡Error!',
                  text: "¡" + " Lo sentimos ha ocurrido un error, intente de nuevo" + "!",
                  type: 'error',
                  showConfirmButton: false,
                  allowOutsideClick: false,
                  timer: 5000,

              })
          }

</script>
</asp:Content>
