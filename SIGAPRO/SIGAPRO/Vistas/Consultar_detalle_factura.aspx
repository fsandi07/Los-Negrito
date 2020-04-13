<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Consultar_detalle_factura.aspx.cs" Inherits="SIGAPRO.Vistas.Consultar_detalle_factura"  validaterequest="false" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link rel="stylesheet" href="bower_components/chartist/dist/chartist.min.css">
    <%-- links para las alertas  --%>
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
                    <h4 class="card-title "> Consulta de Clasificacion Factura</h4>
                  </div>
                    <br />
                    <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="+ DETALLE" OnClick="Btn_redirije_Click" />
                    <br />
                  <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                      <table class="table">
                        <tbody>

                            <asp:GridView ID="grid_detalle_factura" runat="server" CssClass="table table-striped table-no-bordered table-hover" DataSourceID="SqlDataSource2" AllowPaging="True" AllowSorting="True" HorizontalAlign="Center" EditRowStyle-HorizontalAlign="Center" EditRowStyle-VerticalAlign="Middle" EmptyDataRowStyle-HorizontalAlign="Center" EmptyDataRowStyle-VerticalAlign="Middle" FooterStyle-HorizontalAlign="Center" FooterStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" RowStyle-HorizontalAlign="Center" RowStyle-VerticalAlign="Middle" AutoGenerateColumns="False" OnSelectedIndexChanged="grid_detalle_factura_SelectedIndexChanged">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" HeaderText="Editar" SelectText="&lt;i style=&#39;color:orange&#39;class=&#39;fas fa-pen-square fa-2x&#39;&gt;&lt;/i&gt;" />
                                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" InsertVisible="False" SortExpression="ID"></asp:BoundField>
                                    <asp:BoundField DataField="Nombre Clasificacion" HeaderText="Nombre Clasificacion" SortExpression="Nombre Clasificacion"></asp:BoundField>
                                    <asp:BoundField DataField="Descripci&#243;n" HeaderText="Descripci&#243;n" SortExpression="Descripci&#243;n"></asp:BoundField>
                                    <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado"></asp:BoundField>

                                </Columns>
                                <SelectedRowStyle BackColor="#CC6699" HorizontalAlign="Center" VerticalAlign="Middle" />
                              </asp:GridView>
                        </tbody>
                      </table>
                    </div>
                  </div>
                </div>
              </div>
            </div>
       
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand=" select id_detalle as[ID],nombre_detalle as [Nombre Clasificacion], descripcion_detalle as [Descripción], estado_detalle as [Estado] from tb_Detalle_Factura_los_negritos"></asp:SqlDataSource>
    
        <div class="modal fade" id="modalDetalleFactura" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">¿Desea Modificar el detalle de esta Factura?</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                                  <div class="card-body ">                 
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Nombre de la clasificación</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                            <asp:textbox runat="server" ID="txt_nombre_detalle"  class="form-control"></asp:textbox>
                          <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Descripción</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                         <asp:TextBox ID="txt_descripcion_detalle" runat="server" class="form-control"></asp:TextBox>
                        </div>
                      </div>
                    </div>                                        
                </div>
                    Estado:
                        <asp:DropDownList ID="dpt_estado" runat="server"  class="selectpicker" data-style="btn btn-primary btn-round" title="selecione el estado" >
                          <asp:ListItem Value="Activo">Activo</asp:ListItem>
                          <asp:ListItem Value="Inactivo">Inactivo</asp:ListItem>
                      </asp:DropDownList>
                    <div class="modal-footer">
                 <asp:Button ID="btn_modificar" runat="server" Text="Modificar" class="btn btn-success" OnClick="btn_modificar_Click" />
          <button type="button"  class="btn btn-danger" data-dismiss="modal">Cancelar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>

         <script type="text/javascript"> 
            function mensajeDeconfirmacion() {
                swal.fire({
                    title: "¡EXITO!",
                    text: "¡" + "Los Datos se Modificaron Con Exito" + "!",
                    type: 'success',
                    allowOutsideClick: false,
                }).then((result) => {
                    if (result.value) {
                        window.setTimeout('location.href="Consultar_detalle_factura.aspx"')
                  
                    }
                })
         }
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
