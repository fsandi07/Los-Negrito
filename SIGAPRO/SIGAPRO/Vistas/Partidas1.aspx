<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Partidas1.aspx.cs" Inherits="SIGAPRO.Vistas.Partidas1" %>
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
                  
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Numero de Partida</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                            <asp:textbox runat="server" ID="txt_numero_partida"  class="form-control"></asp:textbox>
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
                     <div class="col-md-3">
                        <div class="form-group">
                          <label class="bmd-label-floating">Año</label>
                          <asp:DropDownList ID="Dptyear" runat="server" class="selectpicker" data-style="select-with-transition">
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
                      <label class="col-sm-2 col-form-label">Rango de Fecha:</label>
                    <div class="row">
                        <div class="col-md-6 ml-auto mr-auto">
                            <div class="card">
                                <div class="row">
                                    <label class="col-sm-2 col-form-label">Inicio:</label>
                                    <div class="col-sm-10">
                                        <div class="form-group">
                                             <div class="row">
                                                <div class="col-sm-10">
                                                    <input class="glyphicon glyphicon-calendar" type="date" id="start1" name="trip-start"
                                                        value="date.now();"
                                                        min="01-01-2017" max="31-12-2030">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 ml-auto mr-auto">
                            <div class="card">
                                <div class="row">
                                    <label class="col-sm-2 col-form-label">Final:</label>
                                    <div class="col-sm-10">
                                        <div class="form-group">
                                            <div class="row">
                                                <div class="col-sm-10">
                                                    <input class="glyphicon glyphicon-calendar" type="date" id="start" name="trip-start" onblur="registro()"
                                                        value="date.now();"
                                                        min="01-01-2017" max="31-12-2030">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                
                </div>
              </div>
            </div>
      <div class="row">
                    <div class="col-md-6 ml-auto mr-auto">
                        <div class="card">
                            <div class="card-body text-center">
                                <asp:Button class="btn btn-success" ID="btn_Pago_Cola" runat="server" Text="Registrar Partida" Width="178px" OnClick="btn_Pago_Cola_Click"/>
                            </div>
                        </div>
                    </div>
                </div>

     <asp:HiddenField ID="fechainicio" runat="server" />
    <asp:HiddenField ID="fechafinal" runat="server" />
    <script type="text/javascript"> 
       

        function registro() {
            var fechainicio = document.getElementById("start1").value;
            var fechafinal = document.getElementById("start").value;
            document.getElementById('<%=fechainicio.ClientID%>').value = fechainicio ;
            document.getElementById('<%=fechafinal.ClientID%>').value = fechafinal;
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
