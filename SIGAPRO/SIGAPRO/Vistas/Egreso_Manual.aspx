<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Egreso_Manual.aspx.cs" Inherits="SIGAPRO.Vistas.Egreso_Manual" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="bower_components/chartist/dist/chartist.min.css">
    <%-- links para las alertas  --%>
    <script type="text/javascript" src="jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="sweetalert/sweetalert2.min.css">
    <script type="text/javascript" src="sweetalert/sweetalert2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content"  >
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card ">
                        <div class="card-header ">
                            <h4 class="card-title">Extracción de Datos -
                    <small class="description">Egresos Manuales</small>
                            </h4>
                        </div>
                        <asp:Button class="btn btn-danger col-md-3 ml-auto" ID="btn_cancelar" runat="server" Text="Cancelar" Width="178px" OnClick="btn_cancelar_Click" />
                        <div class="card-body ">
                            <ul class="nav nav-pills nav-pills-warning" role="tablist">
                                <li class="nav-item">
                                    <a class="nav-link active" data-toggle="tab" href="#link1" role="tablist">Asignar Centro de Costos
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" data-toggle="tab" href="#link2" role="tablist">Asignar Partidas y Detalle
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" data-toggle="tab" href="#link5" role="tablist">Aprobación de Factura
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" data-toggle="tab" href="#link6" role="tablist">Estado de pago
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" data-toggle="tab" href="#link3" role="tablist">Información Importante
                                    </a>
                                </li>
                            </ul>
                            <div class="tab-content tab-space">
                                <div class="tab-pane active" id="link1">
                                    Ingrese el numero de Factura 
                                          <div class="card-body ">
                                        <div class="row">
                                            <label class="col-sm-2 col-form-label">Numero:</label>
                                            <div class="form-group">
                                                <asp:TextBox ID="txt_num_factura" runat="server" class="form-control" OnTextChanged="txt_num_factura_TextChanged" AutoPostBack="True"></asp:TextBox><br />
                                                <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                                            </div>
                                        </div>
                                    </div>                                
                                    Seleccione el Centro de Costos.
                                     <br />
                                    <br />
                                    <asp:DropDownList ID="DptCCostos_EXML" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar C. Costos" DataSourceID="SqlDatacentoC" DataTextField="descripcion" DataValueField="numero_centro_costos">
                                        
                                    </asp:DropDownList>
                                    <br />
                                    <br />
                                    Asignación del centro de costos registrado previamente,seleccione en el menu de opciones desplegable.
                                </div>

                                <div class="tab-pane" id="link2">
                                    Asigne la partida correspondiente
                                    <br />
                                    <br />
                                    <asp:DropDownList ID="DptPartida" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar Partida" DataSourceID="SqlDatapartida" DataTextField="descripcion" DataValueField="numero_partida">
                                        
                                    </asp:DropDownList>
                                    <br />
                                    <br />
                                    Asigne la clasificacón que corresponde
                                     <br />
                                    <br />
                                    <asp:DropDownList ID="DptClasificacion" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar Clasificación" DataSourceID="SqlDatadetalle" DataTextField="nombre_detalle" DataValueField="id_detalle">
                                        
                                    </asp:DropDownList>
                                    <br />
                                    Asignacion de partidas de producción registradas por rangos de fecha y su detalle correspondiente.
                                </div>
                                <div class="tab-pane" id="link5">
                                    La factura se encuentra aprobada por hacienda?
                                     <br />
                                    <br />
                                    <div class="btn-group form-check">
                                        <label class="btn btn-primary btn-round">
                                            <asp:RadioButton runat="server" ID="Radioaprobada1" GroupName="radioaprobada" />
                                            Sí 
                                        </label>
                                    </div>
                                    <div class="btn-group form-check">
                                        <label class="btn btn-primary btn-round">
                                            <asp:RadioButton runat="server" ID="Radioaprobada2" GroupName="radioaprobada" />
                                            No  
                                        </label>
                                    </div>
                                    <br />
                                    <br />
                                    Opcion que permite indicar si  la factura se encuentra aprobada o si aun se encuentra pendiente de realizar la aceptación.
                                </div>
                                <div class="tab-pane" id="link6">
                                    La factura se encuentra pagada?
                                      <br />
                                    <br />
                                    <%-- inicio del blouqe--%>
                                    <div class="btn-group form-check">
                                        <label class="btn btn-primary btn-round">
                                            <asp:RadioButton runat="server" ID="Radiopagada_no" GroupName="radiopagada" />
                                            Pendiente   
                                        </label>
                                    </div>
                                    <div class="btn-group form-check">
                                        <label class="btn btn-primary btn-round">
                                            <asp:RadioButton runat="server" ID="Radiopagada_si" GroupName="radiopagada" />
                                            Cancelada  
                                        </label>
                                    </div>
                                    <br />
                                    <br />
                                    En caso de estar cancelada favor llene los siguientes datos?
                                    <br />
                                    <br />
                                    <div class="col-sm-12" id="datospago">
                                        <div class="row">
                                            <div class="col-md-3">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Plazo</label>
                                                    <asp:DropDownList ID="Dpt_plazo_pago" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar Plazo">
                                                        <asp:ListItem Value="0">0 dias</asp:ListItem>
                                                        <asp:ListItem Value="15">15 dias</asp:ListItem>
                                                        <asp:ListItem Value="30">30 dias</asp:ListItem>
                                                        <asp:ListItem Value="45">45 dias</asp:ListItem>
                                                        <asp:ListItem Value="60">60 dias</asp:ListItem>
                                                        <asp:ListItem Value="90">90 dias</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>                                        
                                            <div class="col-md-3">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Banco</label><br />
                                                    <asp:DropDownList ID="DptBanco" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar Banco" DataSourceID="SqlDatabanco" DataTextField="nombre_banco" DataValueField="id_banco">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                            <div class="col-md-3">
                                                <div class="form-group">
                                                    <label class="bmd-label-floating">Metodo de Pago</label>
                                                    <div class="btn-group form-check">
                                                        <asp:DropDownList ID="DptMetodoPago" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar Metodo" DataSourceID="SqlDataMetodo" DataTextField="Nombre" DataValueField="id_Metodo">
                                                           
                                                        </asp:DropDownList>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <%--                fin del bloque--%>
                                    <br />
                                    <br />
                                    Opción para indicar si la factura se encuentra en cuenta por pagar o si ya esta pagada,tambien puede seleccionar los dias de credito.
                                </div>

                                <div class="tab-pane" id="link3">
                                    Favor complete el siguiente formulario
                                    <br />
                                    <br />

                                    <div class="row">
                                        <label class="col-sm-2 col-form-label">Nombre del Comercio:</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">
                                                <asp:TextBox ID="txt_Nombre_comercio_egreso" runat="server" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <label class="col-sm-2 col-form-label">Cédula Juridica:</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">
                                                <asp:TextBox ID="TxtCedula_juridica" runat="server" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <label class="col-sm-2 col-form-label">Monto de la factura:</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">
                                                 <asp:TextBox ID="TxtMontoTotal" class="form-control" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>                                    
                                    <div class="row">
                                        <label class="col-sm-2 col-form-label">Total IVA:</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">                                                
                                                <asp:TextBox ID="TxtTotalIva" class="form-control" runat="server"></asp:TextBox>
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
                                    <br />
                                    <br />
                                    *En caso de ser en dolares la moneda  ingresar el siguiente dato. <br />
                                      <div class="row">
                                        <label class="col-sm-2 col-form-label">Tipo Cambio :</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">
                                                <asp:TextBox ID="TxtTipocambio" runat="server" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <label class="col-sm-2 col-form-label">Fecha de Emisión:</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">
                                                <br />
                                                <input type="date" id="start" name="trip-start"  onblur="verificarDato()"
                                                    value="date.now();"
                                                    min="2017-01-01" max="2030-12-31">
                                            </div>
                                        </div>
                                    </div>                             
                                    <br />
                                    <label class="col-sm-2 col-form-label">Cargar factura física en caso de existir:</label><br />
                                    <br />
                                    <div class="row">

                                        <div class="fileinput fileinput-new text-center" data-provides="fileinput">
                                            <div class="fileinput-new thumbnail">
                                                <img src="assets/img/pdf.jpg" alt="...">
                                            </div>
                                            <div class="fileinput-preview fileinput-exists thumbnail"></div>
                                            <div>
                                                <span class="btn btn-rose btn-round btn-file">
                                                    <span class="fileinput-new">
                                                        <asp:FileUpload ID="file_pdf" runat="server" CssClass="alert-dark" /></span>
                                                </span>
                                                <a href="#pablo" class="btn btn-danger btn-round fileinput-exists" data-dismiss="fileinput"><i class="fa fa-times"></i>Quitar</a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6 ml-auto mr-auto">
                                            <div class="card">
                                                <div class="card-body text-center">
                                                    <asp:Button class="btn btn-success" ID="btn_registrar" runat="server" Text="Registrar Datos" Width="178px" OnClick="btn_registrar_Click" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <br />
                                    <br />
                                    Información importante para el registro de egresos de forma manual sin factura digital.
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <asp:SqlDataSource ID="SqlDatacentoC" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [numero_centro_costos], [descripcion] FROM [tb_centro_de_costos_los_negritos]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDatapartida" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [numero_partida], [descripcion] FROM [tb_Partidas_Los_Negritos]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDatadetalle" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [id_detalle], [nombre_detalle] FROM [tb_Detalle_Factura_los_negritos]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDatabanco" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [id_banco], [nombre_banco] FROM [tb_bancos_los_negritos]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataMetodo" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [id_Metodo], [Nombre] FROM [tb_metodo_Pago_los_negritos]"></asp:SqlDataSource>
            </div>

        </div>
    </div>
    <asp:HiddenField ID="fecha" runat="server" />
    <asp:HiddenField ID="MontoFactura" runat="server" />
    <asp:HiddenField ID="PorcentajeIVA" runat="server" />
    <asp:HiddenField ID="TotalIva" runat="server" />


    <script type="text/javascript">
        function verificarDato() {

            //alert('ha cargado la ventanaJAO');          


            var Fecha = document.getElementById("start").value;
            //captura los valores de los imputs por medio de l Hidden
            document.getElementById('<%=fecha.ClientID%>').value =
                Fecha;

        }


        function CalculaIva() {

            //alert('ha cargado la ventanaJAO');          


            var monto = document.getElementById("Monto_factura").value;
            var porcenIva = document.getElementById("txtporcenIVA").value;            
            
            var calcuporcen = parseFloat(porcenIva) / 100;
            var totaliva = parseFloat(monto) * parseFloat(calcuporcen);           

            //captura los valores de los imputs por medio de l Hidden
            document.getElementById('<%=MontoFactura.ClientID%>').value =
                monto;
            document.getElementById('<%=PorcentajeIVA.ClientID%>').value =
                porcenIva;
            document.getElementById('<%=TotalIva.ClientID%>').value =
                totaliva;


        }

               
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
                text: "¡" + " Lo sentimos ha ocurrido un error intentelo nuevamente" + "!",
                type: 'error',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 5000,

            })
        }
        function mensajevalidacion1() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + "Debe de elegir un banco y un metodo de pago" + "!",
                type: 'error',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 5000,

            })
        }
        function mensajevalidacion2() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + "Debe de elegir un plazo de crédito" + "!",
                type: 'error',
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 5000,

            })
        }
   
        

        function mensajevalidacion3() {
            swal.fire({
                title: '¡Error!',
                text: "¡" + "Debe de elegir un plazo de crédito" + "!",
                type: 'warning', 
                showConfirmButton: false,
                allowOutsideClick: false,
                timer: 2000,
                swalClasses: "height - auto",
            })
        }


    </script>
</asp:Content>
