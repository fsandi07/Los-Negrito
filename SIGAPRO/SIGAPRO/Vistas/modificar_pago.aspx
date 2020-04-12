<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="modificar_pago.aspx.cs" Inherits="SIGAPRO.Vistas.modificar_pago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="bower_components/chartist/dist/chartist.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="col-md-12">
        <div class="card ">
            <div class="card-header card-header-rose card-header-text">
                <div class="card-text">
                    <h4 class="card-title">Registro de Pagos a Colaboradores</h4>
                </div>
            </div>

            <div class="card-body ">
                <div class="row">
                    <label class="col-sm-2 col-form-label">
                        <h6 class="card-title text-danger">
                        Comprobante N°:</label>
                    <asp:Label ID="Lblnumcompro" class="card-title text-danger" runat="server" Text="Label">000</asp:Label>
                </div>
                <h3><span class="tim-note"></span>Datos Colaborador</h3>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Buscar Colaborador:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <asp:DropDownList ID="DptColaborador" runat="server" class="selectpicker" data-style="select-with-transition"  AutoPostBack="True" DataSourceID="SqlDataempleado" DataTextField="nombre" DataValueField="numero_cedula" OnSelectedIndexChanged="DptColaborador_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                </div>
                 <div class="row">
                      <div class="col-md-6">
                        <div class="form-group">
                          <label class="bmd-label-floating">Nombre</label>
                          <asp:TextBox ID="txt_Nombre" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
                        </div>
                      </div>
                      <div class="col-md-6">
                        <div class="form-group">
                          <label class="bmd-label-floating">Apellidos</label>
                          <asp:TextBox ID="txt_Apellido" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                <br />
                <h3><span class="tim-note"></span>Encabezado</h3>
                <div class="row">

                     <div class="col-sm-12">
                     <div class="row">
                      <div class="col-md-3">
                        <div class="form-group">
                          <label class="bmd-label-floating">Mes</label>
                          <asp:DropDownList ID="DptMes" runat="server" class="selectpicker" data-style="select-with-transition">
                                                <asp:ListItem Value="Enero">Enero</asp:ListItem>
                                                <asp:ListItem Value="Febrero">Febrero</asp:ListItem>
                                                <asp:ListItem Value="Marzo">Marzo</asp:ListItem>
                                                <asp:ListItem Value="Abril">Abril</asp:ListItem>
                                                <asp:ListItem Value="Mayo">Mayo</asp:ListItem>
                                                <asp:ListItem Value="Junio">Junio</asp:ListItem>
                                                <asp:ListItem Value="Julio">Julio</asp:ListItem>
                                                <asp:ListItem Value="Agosto">Agosto</asp:ListItem>
                                                <asp:ListItem Value="Septiembre">Septiembre</asp:ListItem>
                                                <asp:ListItem Value="Octubre">Octubre</asp:ListItem>
                                                <asp:ListItem Value="Noviembre">Noviembre</asp:ListItem>
                                                <asp:ListItem Value="Diciembre">Diciembre</asp:ListItem>
                                            </asp:DropDownList>
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
                      <div class="col-md-3">
                        <div class="form-group">
                          <label class="bmd-label-floating">Quincena</label>
                          <asp:DropDownList ID="Dpquincena" runat="server" class="selectpicker" data-style="select-with-transition">
                                                <asp:ListItem Value="1">1</asp:ListItem>
                                                <asp:ListItem Value="2">2</asp:ListItem>
                                            </asp:DropDownList>
                        </div>
                      </div>
                          <div class="col-md-3">
                        <div class="form-group">
                          <label class="bmd-label-floating">Moneda</label>
                           <asp:DropDownList ID="DptMoneda" runat="server" class="selectpicker" data-style="select-with-transition">
                                                <asp:ListItem Value="Colones">Colones</asp:ListItem>
                                                <asp:ListItem Value="Dolares">Dolares</asp:ListItem>
                                            </asp:DropDownList>
                        </div>
                      </div>
                    </div>
                </div>
                    <br />
                    <br />
                      <div class="col-sm-12">
                     <div class="row">
                      <div class="col-md-3">
                        <div class="form-group">
                          <label class="bmd-label-floating">Banco</label>
                          <asp:DropDownList ID="DptBancos" runat="server" class="selectpicker" data-style="select-with-transition" DataSourceID="SqlDataBancos" DataTextField="nombre_banco" DataValueField="id_banco">
                                            </asp:DropDownList>
                        </div>
                      </div>
                      <div class="col-md-3">
                        <div class="form-group">
                          <label class="bmd-label-floating">Partida</label>
                          <asp:DropDownList ID="DptPartida" runat="server" class="selectpicker" data-style="select-with-transition" DataSourceID="SqlDataPartida" DataTextField="numero_partida" DataValueField="numero_partida">
                                               </asp:DropDownList>
                        </div>
                      </div>
                          <div class="col-md-3">
                        <div class="form-group">
                          <label class="bmd-label-floating">Centro Costos</label>
                             <asp:DropDownList ID="DptCentroCostos" runat="server" class="selectpicker" data-style="select-with-transition" DataSourceID="SqlDatacentrocostos" DataTextField="descripcion" DataValueField="numero_centro_costos">
                                            </asp:DropDownList>
                        </div>
                      </div>
                          <div class="col-md-3">
                        <div class="form-group">
                          <label class="bmd-label-floating">Fecha</label><br />

                         <%-- <input type="date" id="start" name="trip-start" onblur="registrofecha()"
                            value="date.now();" <%--value=" <%=(string)Session["fecha_registro"]%>--%>
                           <%-- min="2017-01-01" max="2030-12-31">--%>
                             <input id="txtfecha"  type="text" class="form-control" value ="<%=(string)Session["fecha_registro"]%>"/>
                        </div>
                      </div>
                    </div>
                </div>
                </div> <%--termina el row--%>
               
                
                <h3><span class="tim-note"></span>Ingreso</h3>
                 <div class="row">
                      <div class="col-md-3">
                        <div class="form-group">
                          <label class="bmd-label-floating">Salario Quincenal</label>
                          <input id="txtSalarioquincenal"  type="text" class="form-control" value ="<%=(string)Session["salario_quincenal"]%>"/>
                           
                        </div>
                      </div>                    
                          <div class="col-md-3">
                        <div class="form-group">
                          <label class="bmd-label-floating">Comisión Productividad</label>
                              <input id="txtComisionProduct" type="text" class="form-control" value="<%=(string)Session["comision"]%>"/>
                        </div>
                      </div>
                          <div class="col-md-3">
                        <div class="form-group">
                          <label class="bmd-label-floating">Prestamo</label><br />
                          <input id="txtPrestamo" type="text" class="form-control" value="<%=(string)Session["prestamos"]%>" />
                        </div>
                      </div>
                    </div>
                       <div class="row">
                    <label class="col-sm-2 col-form-label">Días sin goce de salario:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <input id="txtDiassinGoce" type="text" class="form-control" placeholder="Días sin goce" value="<%=(string)Session["dias_sin_goce"]%>"/>
                                <input id="txttotalsinGoce" type="text" class="form-control" placeholder="Total días sin goce" readonly="readonly" value="<%=(string)Session["total_dias_sin_goce"]%>"/>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Feriados:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <input id="txtDiasFeriados" type="text" class="form-control" placeholder="Días feriados" value="<%=(string)Session["dias_feriados"]%>"/>
                                <input id="txttotalferiados" type="text" class="form-control" placeholder="Total feriados" readonly="readonly" value="<%=(string)Session["total_feriados"] %>"/>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Extras:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <input id="txtHorasExtras" type="text" class="form-control" placeholder="Cantidad de Horas" value="<%=(string)Session["horas_extras"]%>" onblur="verificarDato()" />
                                <input id="txttotalExtras" type="text" class="form-control" placeholder="Total Extras" readonly="readonly" value="<%=(string)Session["total_horas_extras"]%>"/>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <label class="col-sm-2 col-form-label">
                        <h6 class="card-title text-warning">Salario Neto:</h6>
                    </label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <input id="txtSalarioNeto" type="text" class="form-control" placeholder="Total Neto" readonly="readonly" value="<%=(string)Session["salario_neto"]%>" />
                        </div>
                    </div>
                </div>
                <h3><span class="tim-note"></span>Deducciones</h3>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Caja del Seguro Social:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <input id="txtCajaSeguro" type="text" class="form-control" placeholder="% CCSS" value="<%=(string)Session["porcentaje_caja"]%>" />
                                <input id="txttotalCaja" type="text" class="form-control" placeholder="Total CCSS" readonly="readonly" value="<%=Session["total_caja"]%>"/>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Impuesto Sobre la Renta:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <input id="txtImpuestoRenta" type="text" class="form-control" onkeypress="return checkIt(event)" value="<%=(string)Session["impuesto_renta"]%>" />
                            </div>

                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Otras deducciones:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <input id="txtTotalOtrasdeud" type="text" class="form-control" placeholder="Total otras deducciones" onblur="deducciones()" onkeypress="return checkIt(event)"value="<%=(string)Session["otras_deducciones"]%>"/>
                                <asp:TextBox ID="txtDescripDedud" class="form-control" placeholder="Descripción de la deducción" runat="server"></asp:TextBox>                                
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">
                        <h6 class="card-title text-warning">Total Deducciones:</h6>
                    </label>

                    <div class="col-sm-10">
                        <div class="form-group">
                            <input id="txtTotalDeducciones" type="text" class="form-control" readonly="readonly" value="<%=(string)Session["total_deducciones"]%>" />
                        </div>
                    </div>
                </div>
                <h3><span class="tim-note"></span>Totales</h3>
                
                <div class="row">
                    <label class="col-sm-2 col-form-label">Saldo Anterior:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <input id="txtsaldoAnterior" type="text" class="form-control" onblur="saldos()" onkeypress="return checkIt(event)" value="<%=(string)Session["saldo_anterior"]%>"/>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Saldo:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <input id="txtSaldo" type="text" class="form-control" readonly="readonly" value="<%=(string)Session["saldo"]%>" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">
                        <h6 class="card-title text-warning">Total depositado:</h6>
                    </label>
                      <div class="col-sm-10">
                        <div class="form-group">
                            <input id="txtTotaldepositado" type="text" class="form-control" readonly="readonly" value="<%=(string)Session["total_depositado"]%>"/>
                        </div>
                    </div>                  
                </div>
                <br />
                <h3><span class="tim-note"></span>Subir documento</h3>
                <br />
                * Puede subirlo en caso de tenerlo listo
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
                   <br />
                <br />
                <div class="row">
                    <div class="col-md-6 ml-auto mr-auto">
                        <div class="card">
                            <div class="card-body text-center">
                                <%--<asp:Button class="btn btn-success" ID="btn_Pago_Cola" runat="server" Text="Registrar Datos" Width="178px" OnClick="btn_Pago_Cola_Click"/>--%>
                                <asp:Button ID="btn_modificar" runat="server" Text="Modificar" class="btn btn-success"  Width="178px" OnClick="btn_modificar_Click"/>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </div>
        <asp:SqlDataSource ID="SqlDatacentrocostos" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [numero_centro_costos], [descripcion] FROM [tb_centro_de_costos_los_negritos]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataempleado" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [numero_cedula], [nombre] FROM [tb_empleado_los_negritos]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataPartida" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [numero_partida], [descripcion] FROM [tb_Partidas_Los_Negritos]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataBancos" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT [id_banco], [nombre_banco] FROM [tb_bancos_los_negritos]"></asp:SqlDataSource>
        
        <%--    inicio del salario neto--%>
    <asp:HiddenField ID="fecha" runat="server"/>
    <asp:HiddenField ID="totalDepositado" runat="server" />
    <asp:HiddenField ID="diasSinGoce" runat="server" />
    <asp:HiddenField ID="SalarioQuincenal" runat="server"/>
    <asp:HiddenField ID="totalsingoce" runat="server" />
    <asp:HiddenField ID="comisionProductividad" runat="server" />
    <asp:HiddenField ID="diasFeriados" runat="server" />
    <asp:HiddenField ID="totalFeriados" runat="server" />
    <asp:HiddenField ID="horasExtras" runat="server" />
    <asp:HiddenField ID="totalExtras" runat="server" />
    <asp:HiddenField ID="salarioneto" runat="server" />
    <asp:HiddenField ID="prestamo" runat="server" />

    <asp:HiddenField ID="porcentajeCCSS" runat="server" />
    <asp:HiddenField ID="totalCCSS" runat="server" />
    <asp:HiddenField ID="otrasDeduccion" runat="server" />
    <asp:HiddenField ID="totalDeducciones" runat="server" />
    <asp:HiddenField ID="impuestoRentas" runat="server" />

    <asp:HiddenField ID="saldoAnterior" runat="server" />
    <asp:HiddenField ID="saldo" runat="server" />
    <asp:HiddenField ID="totalDepositado1" runat="server" />
        <asp:HiddenField ID="PDFvar" runat="server" />
    <script type="text/javascript">       // mensaje de espera

        function registropdf() {

            var pdf = document.getElementById("filePfd").value;
            document.getElementById('<%=PDFvar.ClientID%>').value = pdf;

         }

        function registrofecha() {
            var Fecha_registro = document.getElementById("txtfecha").value;
            document.getElementById('<%=fecha.ClientID%>').value = Fecha_registro ;

        }

    
        function verificarDato(){

            //alert('ha cargado la ventanaJAO');          
            //

            //
            var Salarioquincenal = document.getElementById("txtSalarioquincenal").value;
            var Diassingoce = document.getElementById("txtDiassinGoce").value;
            var Comisionproduct = document.getElementById("txtComisionProduct").value;
            var Diasferiados = document.getElementById("txtDiasFeriados").value;
            var HorasExtras = document.getElementById("txtHorasExtras").value;
            var Prestamo = document.getElementById("txtPrestamo").value;
            

            var Valordias = parseFloat(Salarioquincenal) / 15;
            var Valorhorasextras = parseFloat(Valordias) / 8;
            var TotalValorextras = parseFloat(Valorhorasextras) * 1.5;
            var TotalHorasextras = TotalValorextras * HorasExtras;
            var Totalsingoce = Diassingoce * Valordias;
            var Totalferiados = Diasferiados * Valordias;

            var Salarioneto = parseFloat(Salarioquincenal) + parseFloat(TotalHorasextras) + parseFloat(Comisionproduct) +
                parseFloat(Prestamo) + parseFloat(Totalferiados) - parseFloat(Totalsingoce);



            document.getElementById("txttotalsinGoce").value = Totalsingoce.toFixed(3);
            document.getElementById("txttotalferiados").value = Totalferiados.toFixed(3);
            document.getElementById("txttotalExtras").value = TotalHorasextras;
            document.getElementById("txtSalarioNeto").value = Salarioneto.toFixed(3);
            document.getElementById("txtComisionProduct").value = Comisionproduct;
            document.getElementById("txtPrestamo").value = Prestamo;
            //document.getElementById("txtSalarioquincenal").value = new Intl.NumberFormat().format(Salarioquincenal);

            document.getElementById('<%=SalarioQuincenal.ClientID%>').value = Salarioquincenal;    
            document.getElementById('<%=diasSinGoce.ClientID%>').value = Diassingoce;
            document.getElementById('<%=totalsingoce.ClientID%>').value = Totalsingoce;
            document.getElementById('<%=comisionProductividad.ClientID%>').value = Comisionproduct;
            document.getElementById('<%=diasFeriados.ClientID%>').value = Diasferiados;
            document.getElementById('<%=totalFeriados.ClientID%>').value = Totalferiados;
            document.getElementById('<%=horasExtras.ClientID%>').value = HorasExtras;
            document.getElementById('<%=totalExtras.ClientID%>').value = TotalHorasextras;
            document.getElementById('<%=salarioneto.ClientID%>').value = Salarioneto;
            document.getElementById('<%=prestamo.ClientID%>').value = Prestamo;

        }
        function deducciones() {
            // estos son pára declarar variables y extraerlas del imput.
            var PorcentajeCSS = document.getElementById("txtCajaSeguro").value;
            var salario = document.getElementById("txtSalarioquincenal").value;
            var Totalporcen = parseFloat(PorcentajeCSS) / 100;
            var TotalCaja = parseFloat(salario) * parseFloat(Totalporcen);
            var ImpuestoRenta = document.getElementById("txtImpuestoRenta").value;
            var Otrasdeducc = document.getElementById("txtTotalOtrasdeud").value;
            var SalarionetoT = document.getElementById("txtSalarioNeto").value;
            var TotalDeducciones = parseFloat(TotalCaja) + parseFloat(ImpuestoRenta) + parseFloat(Otrasdeducc);

            var Totaldeposito = parseFloat(SalarionetoT) - parseFloat(TotalDeducciones);

            // estos son para colocar la variable y se muestre en el imput del lado del cliente.
            document.getElementById("txttotalCaja").value = TotalCaja;
            document.getElementById("txtTotalDeducciones").value = TotalDeducciones;
            document.getElementById("txtImpuestoRenta").value = ImpuestoRenta;
            document.getElementById("txtTotalOtrasdeud").value = Otrasdeducc;
            document.getElementById("txtTotaldepositado").value = new Intl.NumberFormat().format(Totaldeposito);
            //estos son para pasar lo de javascript al hideen de asp y usar atras
            document.getElementById('<%=porcentajeCCSS.ClientID%>').value = PorcentajeCSS;
            document.getElementById('<%=totalCCSS.ClientID%>').value = TotalCaja;
            document.getElementById('<%=otrasDeduccion.ClientID%>').value = Otrasdeducc;
            document.getElementById('<%=totalDeducciones.ClientID%>').value = TotalDeducciones;
            document.getElementById('<%=impuestoRentas.ClientID%>').value = ImpuestoRenta;
            document.getElementById('<%=totalDepositado.ClientID%>').value = Totaldeposito;

        }
        function saldos() {
            var Saldoanterior = document.getElementById("txtsaldoAnterior").value;
            var Totaldeduccion = document.getElementById("txtTotalDeducciones").value;
            var Saldo = parseFloat(Totaldeduccion) - parseFloat(Saldoanterior);
            document.getElementById("txtSaldo").value = Saldo.toFixed(3);

            document.getElementById('<%=saldoAnterior.ClientID%>').value = Saldoanterior;
            document.getElementById('<%=saldo.ClientID%>').value = Saldo;
            
        }
            //mensaje de conrfimacion
            function mensajeDeconfirmacion() {
                swal.fire({
                    title: "¡EXITO!",
                    text: "¡" + "Los Datos se Modificaron Con Exito" + "!",
                    type: 'success',
                    allowOutsideClick: false,
                }).then((result) => {
                    if (result.value) {
                        window.setTimeout('location.href="Consultar_Pagos_Empleados.aspx"')
                  
                    }
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
