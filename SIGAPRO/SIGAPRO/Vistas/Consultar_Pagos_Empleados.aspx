<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Consultar_Pagos_Empleados.aspx.cs" Inherits="SIGAPRO.Vistas.Consultar_Pagos_Empleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript" src="jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="sweetalert/sweetalert2.min.css">
    <script type="text/javascript" src="sweetalert/sweetalert2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content">   
              <div class="col-md-12">
                <div class="card">
                  <div class="card-header card-header-icon card-header-rose">
                    <div class="card-icon">
                      <i class="material-icons">group</i>
                    </div>
                    <h4 class="card-title "> Consulta de pagos Colaboradores</h4>
                  </div>
                    <asp:Button ID="Btnredirije"  class="btn btn-primary col-md-3 ml-auto" runat="server" Text="+ PAGO" OnClick="Btnredirije_Click" />
                  <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                      <table class="table">
                       
                        <tbody>
                            <asp:GridView ID="grid_pagos_empleados" CssClass="table table-striped table-no-bordered table-hover" runat="server" DataSourceID="SqlDataconsulta" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="N° Comprobante" OnRowCommand="grid_pagos_empleados_RowCommand" OnSelectedIndexChanged="grid_pagos_empleados_SelectedIndexChanged1">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" HeaderText="Detalles"></asp:CommandField>
                                    <asp:BoundField DataField="N&#176; Comprobante" HeaderText="N&#176; Comprobante" ReadOnly="True" InsertVisible="False" SortExpression="N&#176; Comprobante"></asp:BoundField>
                                     <asp:BoundField DataField="Nombre Empleado" HeaderText="Nombre Empleado" ReadOnly="True" SortExpression="Nombre Empleado"></asp:BoundField>
                                    <asp:BoundField DataField="Mes" HeaderText="Mes" SortExpression="Mes"></asp:BoundField>
                                    <asp:BoundField DataField="Periodo" HeaderText="Periodo" SortExpression="Periodo"></asp:BoundField>
                                    <asp:BoundField DataField="Quincena" HeaderText="Quincena" SortExpression="Quincena"></asp:BoundField>
                                    <asp:BoundField DataField="Moneda" HeaderText="Moneda" SortExpression="Moneda" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" Visible="False"></asp:BoundField>                                 
                                    <asp:BoundField DataField="Salario Quincenal" HeaderText="Salario Quincenal" SortExpression="Salario Quincenal"></asp:BoundField>
                                    <asp:BoundField DataField="Comision" HeaderText="Comision" SortExpression="Comision" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Prestamos" HeaderText="Prestamos" SortExpression="Prestamos" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Dias sin Goce" HeaderText="Dias sin Goce" SortExpression="Dias sin Goce" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Total sin Goce" HeaderText="Total sin Goce" ReadOnly="True" SortExpression="Total sin Goce" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Dias Feriados" HeaderText="Dias Feriados" SortExpression="Dias Feriados" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Total Feriado" HeaderText="Total Feriado" ReadOnly="True" SortExpression="Total Feriado" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Horas Extras" HeaderText="Horas Extras" SortExpression="Horas Extras" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Total Extras" HeaderText="Total Extras" SortExpression="Total Extras" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Salario Neto" HeaderText="Salario Neto" SortExpression="Salario Neto" ></asp:BoundField>
                                    <asp:BoundField DataField="Porcentaje CCSS" HeaderText="Porcentaje CCSS" SortExpression="Porcentaje CCSS" Visible="False" ></asp:BoundField>
                                    <asp:BoundField DataField="Total Caja" HeaderText="Total Caja" SortExpression="Total Caja" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Impuesto Renta" HeaderText="Impuesto Renta" SortExpression="Impuesto Renta" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Otras Deducciones" HeaderText="Otras Deducciones" SortExpression="Otras Deducciones" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Detalle Deduducciones" HeaderText="Detalle Deduducciones" SortExpression="Detalle Deduducciones" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Total Deducciones" HeaderText="Total Deducciones" ReadOnly="True" SortExpression="Total Deducciones" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Saldo Anterior" HeaderText="Saldo Anterior" SortExpression="Saldo Anterior" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Total Saldo" HeaderText="Total Saldo" ReadOnly="True" SortExpression="Total Saldo" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Banco" HeaderText="Banco" SortExpression="Banco"></asp:BoundField>
                                    <asp:BoundField DataField="Centro Costos" HeaderText="Centro Costos" SortExpression="Centro Costos"></asp:BoundField>
                                    <asp:BoundField DataField="Nombre PDF" HeaderText="Nombre PDF" SortExpression="Nombre PDF" Visible="False" ></asp:BoundField>
                                    <asp:ButtonField  Text="<i class='far fa-file-pdf'></i>" CommandName="PDF"  HeaderText="PDF" />
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado"></asp:BoundField>
                                </Columns>
                                  <EditRowStyle BorderStyle="None" HorizontalAlign="Center" VerticalAlign="Middle"></EditRowStyle>
                                    <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <%--<SelectedRowStyle BackColor="#CC6699" HorizontalAlign="Center" VerticalAlign="Middle" />--%>
                            </asp:GridView>                          

                        </tbody>
                      </table>
                    </div>
                  </div>
                </div>
              </div>
            </div>
    <asp:SqlDataSource ID="SqlDatapagos" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT * FROM [tb_pago_emple_los_negritos]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand="SELECT [cedula_usuario], [nombre_usuario], [apellido1], [nick_name], [correo_electronico] FROM [tb_Usuarios_Los_negritos]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataconsulta" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="select a.Id_comprobante as [N° Comprobante], a.Mes,a.Periodo,a.Quincena,a.Moneda,a.Fecha_registro as [Fecha],b.nombre +' '+b.apellido1 +' '+b.apellido2 as [Nombre Empleado],
a.Salario_quincenal as [Salario Quincenal],a.Comision,a.Prestamos,a.Dias_sinGoce as [Dias sin Goce],CONVERT(numeric(10,3), a.Total_sinGoce) as [Total sin Goce],a.Dias_feriados as [Dias Feriados],CONVERT(numeric(10,3), a.Total_feriados) as [Total Feriado],
a.Horas_extras as [Horas Extras],a.Total_extras as [Total Extras],a.Salario_neto as [Salario Neto],a.Porcen_caja [Porcentaje CCSS],a.Total_caja as [Total Caja],a.Impuesto_renta as [Impuesto Renta],a.Otras_deducc as [Otras Deducciones],a.Detalle_otras_deduc as [Detalle Deduducciones],CONVERT(numeric(10,0), a.Total_deduc) as [Total Deducciones],
a.Saldo_anterior as [Saldo Anterior],CONVERT(numeric(10,0), a.Saldo) as [Total Saldo],c.nombre_banco as [Banco],a.Id_centro_costos as [Centro Costos],a.Realname_pdf as [Nombre PDF],a.Estado
from tb_pago_emple_los_negritos a, tb_empleado_los_negritos b, tb_bancos_los_negritos c
where a.Id_colaborador = b.numero_cedula and a.Id_banco = c.id_banco
"></asp:SqlDataSource>
    <br />  
    
    <%-- Modal para los datos  Creados --%>
    <div class="modal fade" id="ModalDocumentos" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Información del Pago</h5>
                    <br />                   
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
             <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
             <meta charset="utf-8">  
                     <p align="right">Comprobante N°:<asp:Label  ID="LblComprobante" Text="" class="col-sm-2 col-form-label" runat="server" ForeColor="Red" Font-Bold="True" /></p>
                    <div align="center"><img src="assets/img/default-avatar.png" width="150" height="150"></div>                                                           
                    <p align="center">Nombre :<asp:Label ID="Lblnombre"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label></p> 
                    <p align="center">ID:<asp:Label ID="LblID_colabo"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label></p>
                    Periodo.......................: <asp:Label ID="LblQuincena"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br />
                    Banco.........................: <asp:Label ID="LblBanco"  class="col-sm-2 col-form-label" runat="server"    Text="">  </asp:Label><br /> 
                    Moneda........................: <asp:Label ID="LblMoneda"  class="col-sm-2 col-form-label" runat="server"   Text=""></asp:Label><br /> 
                    <asp:Label ID="Label5"  class="col-sm-2 col-form-label" runat="server" Text="-----------------------------------------------------------------------------------------"></asp:Label><br />
                    Salario Quincenal.............:<asp:Label ID="LblQuincenal"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br /> 
                    Dias sin goce.................:<asp:Label ID="Lbldias_sin_goce"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br /> 
                    Total sin goce................:<asp:Label ID="Lbl_total_sin_goce"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br /> 
                    Comision Produc...............:<asp:Label ID="LblComision"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br /> 
                    Préstamo......................:<asp:Label ID="LblPretsamo"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br /> 
                    Dias Feriados:<asp:Label ID="LblDiasFeriados"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br /> 
                    Total Feriados:<asp:Label ID="LblTotal_feriado"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br /> 
                    Horas Extras:<asp:Label ID="LblHoras_extras"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br /> 
                    Total Extras:<asp:Label ID="LblTotal_extras"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br /> 
                    Salario Neto:<asp:Label ID="LblSalario_neto"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br />
                    <br /> 
                    <asp:Label ID="Ltitulodeduc"  class="col-sm-2 col-form-label" runat="server" Text="" Font-Bold="True" ForeColor="#0000CC">Deducciones</asp:Label><br /> 
                    % CCSS:<asp:Label ID="LblCCSS"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br />
                    Total CCSS:<asp:Label ID="LblTotal_ccss"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br />
                    ISR:<asp:Label ID="LblISR"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br />
                    Otras Deducciones:<asp:Label ID="LblOtras_deduc"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br />
                    Cocepto de:<asp:Label ID="LblConcepto"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br />
                    Total Deducciones:<asp:Label ID="LblTotal_Deduc"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br />
                    <br />
                    <asp:Label ID="Label7"  class="col-sm-2 col-form-label" runat="server" Text="" Font-Bold="True" ForeColor="#0000CC">Totales</asp:Label><br /> 
                    Total Depositado:<asp:Label ID="LblTotal_depositado"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br />
                    Saldo Anterior:<asp:Label ID="LblSaldo_anterior"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br />
                    Saldo:<asp:Label ID="LblSaldo"  class="col-sm-2 col-form-label" runat="server" Text=""></asp:Label><br />
                       
                    
                    
                    <div class="modal-footer">
                        <asp:Button ID="Btnmodificar" class="btn btn-primary " runat="server" Text="Modificar Datos" OnClick="Btnmodificar_Click" />                       
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%-- fin de modal  --%>
    
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
     <script type="text/javascript">
   //Alerta para actualizar o ver detalles 
        function Actualizar(){
          Swal.fire({
            title: '¿Que Accion Desea Realizar?',
            text: "¡Por favor eliga una opccion!",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: '¡Modificar!',
              allowOutsideClick: false,        
          }).then((result) => {
              if (result.value) {
               window.setTimeout('location.href="modificar_pago.aspx"')
              //Swal.fire({
              //  //title: 'Borrado',
              //  //text:'Tu Archivo se ha borrado.',
              //  //type:'success',
              //  //allowOutsideClick: false,
                  
              //})
              }
          })          
         };

         function mensajeEspera() {
             let timerInterval
             Swal.fire({
                 title: '¡Abriendo PDF!',

                 timer: 5000,
                 allowOutsideClick: false,
                 onBeforeOpen: () => {

                     Swal.showLoading()

                     timerInterval = setInterval(() => {
                         Swal.getContent().querySelector('strong')
                             .textContent = (Swal.getTimerLeft() / 100)
                                 .toFixed(0)
                     }, 100)
                 },
                 onClose: () => {
                     clearInterval(timerInterval)
                 }

             })

             //window.setTimeout('location.href="Consultar_Pagos_Empleados.aspx"', 1000)

         }
         </script>

</asp:Content>
