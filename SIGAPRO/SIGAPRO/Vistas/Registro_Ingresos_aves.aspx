<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Registro_Ingresos_aves.aspx.cs" Inherits="SIGAPRO.Vistas.Registro_Ingresos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="bower_components/chartist/dist/chartist.min.css">
    <%-- links para las alertas  --%>
    <script type="text/javascript" src="jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="sweetalert/sweetalert2.min.css">
    <script type="text/javascript" src="sweetalert/sweetalert2.min.js"></script>
    <script src="Scripts\Focus.js"></script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card ">
                        <div class="card-header ">
                            <h4 class="card-title">Ingresos Manuales -
                    <small class="description">Venta de Aves</small>
                            </h4>
                        </div>
                        <asp:Button class="btn btn-danger col-md-3 ml-auto" ID="btn_cancelar" runat="server" Text="Cancelar" Width="178px" OnClick="btn_cancelar_Click" />
                        <div class="card-body ">
                            <ul class="nav nav-pills nav-pills-warning" role="tablist">
                                <li class="nav-item">
                                    <a class="nav-link active" data-toggle="tab" href="#link2" role="tablist">Asignar Partidas
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" data-toggle="tab" href="#link6" role="tablist">Estado de pago
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link " data-toggle="tab" href="#link3" role="tablist">Información Importante
                                    </a>
                                </li>
                            </ul>
                            <div class="tab-content tab-space">

                                <div class="tab-pane active" id="link2">
                                    Asigne la partida correspondiente
                                    <br />
                                    <br />
                                    <div class="col-lg-5 col-md-6 col-sm-3">
                                        <asp:DropDownList ID="Dpt_partida" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar Partida" DataSourceID="SqlDataPartida" DataTextField="descripcion" DataValueField="numero_partida">
                                        </asp:DropDownList>
                                    </div>
                                    <br />
                                    <br />
                                    Asignacion de partidas de producción registradas por rangos de fecha.
                                </div>
                                <div class="tab-pane" id="link3">
                                    Favor complete el siguiente formulario
                                    <br />
                                    <br />
                                    <div class="card-body ">
                                        <div class="row">
                                            <label class="col-sm-2 col-form-label">Numero de Factura:</label>
                                            <div class="form-group">
                                                <asp:TextBox ID="txt_num_factura" runat="server" class="form-control"></asp:TextBox><br />
                                                <%--<asp:Button ID="Btn_validar_num_factura" runat="server" Text="Validar Factura" class="btn btn-primary btn-sm" />--%>
                                                <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <label class="col-sm-2 col-form-label">Nombre del Comercio:</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">
                                                <asp:TextBox ID="txt_Nombre_comercio_ingreso" runat="server" class="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <label class="col-sm-2 col-form-label">Fecha de Emisión:</label>
                                        <div class="col-sm-10"> <br />                                         
                                            <input type="date" id="start" name="trip-start"
                                                value=date.now();
                                                min="2017-01-01" max="2030-12-31">
                                            <%--<div class="form-group">
                                                <asp:Calendar ID="Calendar_fecha_egreso" runat="server" CssClass="alert-dark"></asp:Calendar>
                                            </div>--%>
                                        </div>
                                    </div>
                                    <%--inicio de los bloques--%>
                                    <div class="row">
                                        <div class="col-md-6 ml-auto mr-auto">
                                            <div class="card">
                                                <div class="card-body text-center">
                                                    <code>Información del ingreso</code>
                                                    <div class="row">
                                                        <label class="col-sm-2 col-form-label">Monto de la factura:</label>
                                                        <div class="col-sm-10">
                                                            <div class="form-group">
                                                                <input id="txtmontofactura" type="text" class="form-control" />
                                                                <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                                                            </div>
                                                        </div>
                                                        <label class="col-sm-2 col-form-label">Detalle de la factura:</label>
                                                        <div class="col-sm-10">
                                                            <div class="form-group">
                                                                <div class="col-lg-5 col-md-6 col-sm-3">
                                                                    <asp:DropDownList ID="Dptdetalle" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar Partida" DataSourceID="SqlDatadetalle" DataTextField="nombre_detalle" DataValueField="id_detalle">
                                            
                                        </asp:DropDownList>
                                    </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-6 ml-auto mr-auto">
                                            <div class="card">
                                                <div class="card-body text-center">
                                                    <code>Otras Cargas factura (-)</code>
                                                    <div class="row">
                                                        <label class="col-sm-2 col-form-label">Monto de la Carga:</label>
                                                        <div class="col-sm-10">
                                                            <div class="form-group">
                                                                <input id="txtmontocarga" type="text" class="form-control" />
                                                                <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                                                            </div>
                                                        </div>
                                                        <label class="col-sm-2 col-form-label">Detalle de la Carga:</label>
                                                        <div class="col-sm-10">
                                                            <div class="form-group">
                                                                <asp:TextBox ID="txt_detalle_carga" runat="server" class="form-control"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                    <%--fin de los bloques--%>

                                    <div class="row">
                                        <label class="col-sm-2 col-form-label">Ingrese porcentaje (%)IVA:</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">
                                                <input id="txtporcenIva" type="text" class="form-control" onblur="verificarDato()" />
                                                <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <label class="col-sm-2 col-form-label">Total IVA</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">
                                                <input id="txttotalIva" type="text" class="form-control" />
                                                <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                                            </div>
                                        </div>
                                        <label class="col-sm-2 col-form-label">Total (-) IVA :</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">
                                                <input id="txtmenosIva" type="text" class="form-control" />
                                            </div>
                                        </div>
                                        <label class="col-sm-2 col-form-label">Total (-) IVA (-) Carga :</label>
                                        <div class="col-sm-10">
                                            <div class="form-group">
                                                <input id="txttotalmonto" type="text" class="form-control" />
                                            </div>
                                        </div>
                                    </div>
                                    <br />
                                     <label class="col-sm-4 col-form-label">Cargar factura física en caso de existir:</label>
                                        <br />
                                    <br />
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

                                <div class="tab-pane" id="link6">
                                    La factura se encuentra pagada?
                                    <br />
                                    <br />
                                    <div class="btn-group form-check">
                                        <label class="btn btn-primary btn-round">
                                            <asp:RadioButton runat="server" ID="Radiopagada_si" GroupName="radiopagada"  />
                                            Pendiente   
                                        </label>
                                    </div>
                                    <div class="btn-group form-check">
                                        <label class="btn btn-primary btn-round">
                                            <asp:RadioButton runat="server" ID="Radiopagada_no" GroupName="radiopagada"  />
                                            Pagada   
                                        </label>
                                    </div>

                                    <div id="dptplazo">
                                    <br />
                                    <br />
                                    Seleccione el plazo de credito en caso de estar pendiente.
                                        <br />
                                    <br />
                                    <div class="col-lg-5 col-md-6 col-sm-3">
                                        <asp:DropDownList ID="Dpt_plazo_pago" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar Plazo" >
                                            <asp:ListItem Value="15">15 dias</asp:ListItem>
                                            <asp:ListItem Value="30">30 dias</asp:ListItem>
                                            <asp:ListItem Value="45">45 dias</asp:ListItem>
                                            <asp:ListItem Value="60">60 dias</asp:ListItem>
                                            <asp:ListItem Value="90">90 dias</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    </div>
                                 <br />
                                    <br />
                                    Opción para indicar si la factura se encuentra en cuenta por pagar o si ya esta pagada,tambien puede seleccionar los dias de credito.
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <asp:SqlDataSource ID="SqlDatadetalle" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [id_detalle], [nombre_detalle] FROM [tb_Detalle_Factura_los_negritos]"></asp:SqlDataSource>

        <asp:SqlDataSource ID="SqlDataPartida" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [numero_partida], [descripcion] FROM [tb_Partidas_Los_Negritos]"></asp:SqlDataSource>
    </div>



    <asp:HiddenField ID="fecha" runat="server" />
    <asp:HiddenField ID="totalIva" runat="server" />
    <asp:HiddenField ID="totalmenosIva" runat="server" />
    <asp:HiddenField ID="totalmenosCargas" runat="server" />  
    <asp:HiddenField ID="montoFacatura" runat="server" />
    <asp:HiddenField ID="otrasCargas" runat="server" />
    <asp:HiddenField ID="porcenIva" runat="server" />
    <script type="text/javascript">       // mensaje de espera



        function verificarDato() {

            //alert('ha cargado la ventanaJAO');          

            var primerValor = document.getElementById("txtmontofactura").value;
            var segundoValor = document.getElementById("txtmontocarga").value;
            var iva = document.getElementById("txtporcenIva").value;
            var porcenIva = iva / 100;
            var totalIva = parseFloat(porcenIva) * parseFloat(primerValor);
            var totalmenosIva = parseFloat(primerValor) - parseFloat(totalIva);
            var totalmenosCargas = parseFloat(primerValor) - parseFloat(segundoValor) - parseFloat(totalIva);
            var fecha = document.getElementById("start").value;

            var resultadosinIva = parseFloat(primerValor) - parseFloat(segundoValor);
            document.getElementById("txttotalIva").value = totalIva;
            document.getElementById("txtmenosIva").value = totalmenosIva;
            document.getElementById("txttotalmonto").value = totalmenosCargas;
            

            //captura los valores de los imputs por medio de l Hidden
            document.getElementById('<%=montoFacatura.ClientID%>').value =
                document.getElementById("txtmontofactura").value;
            document.getElementById('<%=totalIva.ClientID%>').value =
                totalIva;
            document.getElementById('<%=totalmenosIva.ClientID%>').value =
                totalmenosIva;
            document.getElementById('<%=totalmenosCargas.ClientID%>').value =
                totalmenosCargas;
            document.getElementById('<%=fecha.ClientID%>').value =
                fecha;
            document.getElementById('<%=otrasCargas.ClientID%>').value =
                segundoValor;
            document.getElementById('<%=porcenIva.ClientID%>').value =
                document.getElementById("txtporcenIva").value;
        }


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
