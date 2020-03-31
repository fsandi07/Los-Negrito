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

                              <asp:GridView runat="server" CssClass="table table-striped table-no-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id_comprobante" DataSourceID="SqlDatapagos" EnablePersistedSelection="True" AllowPaging="True" OnSelectedIndexChanged="grid_pagos_empleados_SelectedIndexChanged" ID="grid_pagos_empleados" >
                                  <Columns>
                                      <asp:CommandField ShowSelectButton="True" HeaderText="Editar" ></asp:CommandField>
                                      <asp:BoundField DataField="Id_comprobante" HeaderText="Id" ReadOnly="True" InsertVisible="False" SortExpression="Id_comprobante"></asp:BoundField>
                                      <asp:BoundField DataField="Mes" HeaderText="Mes" SortExpression="Mes"></asp:BoundField>
                                      <asp:BoundField DataField="Periodo" HeaderText="Periodo" SortExpression="Periodo"></asp:BoundField>
                                      <asp:BoundField DataField="Quincena" HeaderText="Quincena" SortExpression="Quincena"></asp:BoundField>
                                      <asp:BoundField DataField="Moneda" HeaderText="Moneda" SortExpression="Moneda"></asp:BoundField>
                                      <asp:BoundField DataField="Fecha_registro" HeaderText="Fecha Registro" SortExpression="Fecha_registro"></asp:BoundField>
                                      <asp:BoundField DataField="Id_colaborador" HeaderText="ID Colaborador" SortExpression="Id_colaborador"></asp:BoundField>
                                      <asp:BoundField DataField="Salario_quincenal" HeaderText="Salario_quincenal" SortExpression="Salario_quincenal"></asp:BoundField>
                                      <asp:BoundField DataField="Comision" HeaderText="Comision" SortExpression="Comision"></asp:BoundField>
                                      <asp:BoundField DataField="Prestamos" HeaderText="Prestamos" SortExpression="Prestamos"></asp:BoundField>
                                      <asp:BoundField DataField="Dias_sinGoce" HeaderText="Dias_sinGoce" SortExpression="Dias_sinGoce"></asp:BoundField>
                                      <asp:BoundField DataField="Total_sinGoce" HeaderText="Total_sinGoce" SortExpression="Total_sinGoce"></asp:BoundField>
                                      <asp:BoundField DataField="Dias_feriados" HeaderText="Dias_feriados" SortExpression="Dias_feriados"></asp:BoundField>
                                      <asp:BoundField DataField="Total_feriados" HeaderText="Total_feriados" SortExpression="Total_feriados"></asp:BoundField>
                                      <asp:BoundField DataField="Horas_extras" HeaderText="Horas_extras" SortExpression="Horas_extras"></asp:BoundField>
                                      <asp:BoundField DataField="Total_extras" HeaderText="Total_extras" SortExpression="Total_extras"></asp:BoundField>
                                      <asp:BoundField DataField="Salario_neto" HeaderText="Salario_neto" SortExpression="Salario_neto"></asp:BoundField>
                                      <asp:BoundField DataField="Porcen_caja" HeaderText="Porcen_caja" SortExpression="Porcen_caja"></asp:BoundField>
                                      <asp:BoundField DataField="Impuesto_renta" HeaderText="Impuesto_renta" SortExpression="Impuesto_renta"></asp:BoundField>
                                      <asp:BoundField DataField="Otras_deducc" HeaderText="Otras_deducc" SortExpression="Otras_deducc"></asp:BoundField>
                                      <asp:BoundField DataField="Detalle_otras_deduc" HeaderText="Detalle_otras_deduc" SortExpression="Detalle_otras_deduc"></asp:BoundField>
                                      <asp:BoundField DataField="Total_deduc" HeaderText="Total_deduc" SortExpression="Total_deduc"></asp:BoundField>
                                      <asp:BoundField DataField="Saldo_anterior" HeaderText="Saldo_anterior" SortExpression="Saldo_anterior"></asp:BoundField>
                                      <asp:BoundField DataField="Saldo" HeaderText="Saldo" SortExpression="Saldo"></asp:BoundField>
                                      <asp:BoundField DataField="Total_depositado" HeaderText="Total_depositado" SortExpression="Total_depositado"></asp:BoundField>
                                      <asp:BoundField DataField="Id_banco" HeaderText="Id_banco" SortExpression="Id_banco" />
                                      <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                                      <asp:BoundField DataField="Id_centro_costos" HeaderText="Id_centro_costos" SortExpression="Id_centro_costos" />
                                      <asp:BoundField DataField="Total_caja" HeaderText="Total_caja" SortExpression="Total_caja" />
                                      <asp:BoundField DataField="Realname_pdf" HeaderText="Realname_pdf" SortExpression="Realname_pdf" />
        </Columns>
<EditRowStyle BorderStyle="None" HorizontalAlign="Center" VerticalAlign="Middle"></EditRowStyle>
                                    <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <SelectedRowStyle BackColor="#CC6699" HorizontalAlign="Center" VerticalAlign="Middle" />
    </asp:gridview>

                        </tbody>
                      </table>
                    </div>
                  </div>
                </div>
              </div>
            </div>
    <asp:SqlDataSource ID="SqlDatapagos" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="SELECT * FROM [tb_pago_emple_los_negritos]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand="SELECT [cedula_usuario], [nombre_usuario], [apellido1], [nick_name], [correo_electronico] FROM [tb_Usuarios_Los_negritos]"></asp:SqlDataSource>
    <br />   
    
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
         </script>

</asp:Content>
