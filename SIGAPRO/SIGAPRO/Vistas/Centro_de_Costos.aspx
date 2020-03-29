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
                    <h4 class="card-title">Agregar un Centro de Costos:</h4>
                </div>
            </div>
            <div class="card-body ">                
                    <div class="row">
                        <label class="col-sm-2 col-form-label">Numero de Centro de Costos:</label>
                        <div class="col-sm-10">
                            <div class="form-group">
                                <asp:TextBox runat="server" ID="txt_centro_de_costos" class="form-control"></asp:TextBox>
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
            </div>
        </div>
    </div>
      <div class="row">
                    <div class="col-md-6 ml-auto mr-auto">
                        <div class="card">
                            <div class="card-body text-center">
                                <asp:Button class="btn btn-success" ID="btn_Regis_Centro" runat="server" Text="Registrar Costos" Width="178px" OnClick="btn_Pago_Cola_Click"/>
                            </div>
                        </div>
                    </div>
                </div>
     <script type="text/javascript">
        // mensaje de espera 
        function mensajeEspera() {
            let timerInterval
            Swal.fire({
                title: '¡Extrayendo XML Por Favor Espere!',

                timer: 5000,
                allowOutsideClick: false,
                onBeforeOpen: () => {

                    Swal.showLoading()

                    timerInterval = setInterval(() => {
                        Swal.getContent().querySelector('strong')
                            .textContent = (Swal.getTimerLeft() / 1000)
                                .toFixed(0)
                    }, 100)
                },
                onClose: () => {
                    clearInterval(timerInterval)
                }

            })

            window.setTimeout('location.href="Datos_del_XML.aspx"', 5000)

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
