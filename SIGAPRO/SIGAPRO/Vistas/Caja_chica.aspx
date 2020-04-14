<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Caja_chica.aspx.cs" Inherits="SIGAPRO.Vistas.Caja_chica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="bower_components/chartist/dist/chartist.min.css">
    <%-- links para las alertas  --%>
    <script type="text/javascript" src="jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="sweetalert/sweetalert2.min.css">
    <script type="text/javascript" src="sweetalert/sweetalert2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <br />
    <div class="col-md-12">
        <div class="card ">
            <div class="card-header card-header-rose card-header-text">
                <div class="card-text">
                    <h4 class="card-title">Agregar Caja Chica</h4>
                </div>
            </div>
            <div class="card-body ">
                <div class="row">
                    <label class="col-sm-2 col-form-label">Nombre:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="txt_nombre_caja" class="form-control"></asp:TextBox>
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
                        <label class="col-sm-2 col-form-label">Saldo Inicial</label>
                        <div class="col-sm-10">
                            <div class="form-group">
                                <asp:TextBox ID="TxtSaldo_inicial" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Fecha apertura</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <input type="date" id="start" name="trip-start" onblur="registrofecha()"
                                value="date.now();"
                                min="2017-01-01" max="2030-12-31">
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
                    <asp:Button class="btn btn-success" ID="Btn_redirije" runat="server" Text="Registrar" OnClick="Btn_redirije_Click" />
                </div>
            </div>
        </div>
    </div>
        <asp:HiddenField ID="fecha" runat="server"/>
    <script type="text/javascript">  
     function registrofecha() {
            var Fecha_registro = document.getElementById("start").value;
            document.getElementById('<%=fecha.ClientID%>').value = Fecha_registro ;

        }
         </script>


    <script type="text/javascript">  
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
