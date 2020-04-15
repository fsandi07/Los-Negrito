<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Registro_movi_banc.aspx.cs" Inherits="SIGAPRO.Vistas.Registro_movi_banc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%-- links para las alertas  --%>
    <script type="text/javascript" src="jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="sweetalert/sweetalert2.min.css">
    <script type="text/javascript" src="sweetalert/sweetalert2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <div class="col-md-12">
        <div class="card ">
            <div class="card-header card-header-rose card-header-text">
                <div class="card-text">
                    <h4 class="card-title">Agregar un Movimiento de Banco</h4>
                </div>
            </div>
            <div class="card-body ">
                <div class="row">
                    <label class="col-sm-2 col-form-label">Nombre del Movimiento</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="txt_nombre_banco" class="form-control"></asp:TextBox>
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
                    <label class="col-sm-2 col-form-label">Fecha de Registro:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <br />
                            <input type="date" id="start" name="trip-start" onblur="verificarDato()"
                                value="date.now();"
                                min="2017-01-01" max="2030-12-31">
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Tipo de Moneda:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:DropDownList ID="DptMoneda" runat="server" class="selectpicker" data-style="select-with-transition" title="Seleccionar Moneda">
                                <asp:ListItem Value="CRC">CRC</asp:ListItem>
                                <asp:ListItem Value="USD">USD</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Asociar Banco:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:DropDownList ID="DptBanco" runat="server" class="selectpicker" data-style="select-with-transition" title="Seleccionar Banco" DataSourceID="SqlDataBanco" DataTextField="nombre_banco" DataValueField="id_banco">
                            </asp:DropDownList>
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
    <asp:SqlDataSource ID="SqlDataBanco" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [id_banco], [nombre_banco] FROM [tb_bancos_los_negritos]"></asp:SqlDataSource>
        <asp:HiddenField ID="fecha" runat="server" />
       
      <script type="text/javascript">
    
    function verificarDato() {

            //alert('ha cargado la ventanaJAO');          


            var Fecha = document.getElementById("start").value;
            //captura los valores de los imputs por medio de l Hidden
            document.getElementById('<%=fecha.ClientID%>').value =
                Fecha;

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
