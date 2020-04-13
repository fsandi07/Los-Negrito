<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Ver_Usuarios.aspx.cs" Inherits="SIGAPRO.Vistas.Ver_Usuarios"  validaterequest="false" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 84px;
        }
        .auto-style2 {
            width: 114px;
        }
        .auto-style4 {
            width: 69px;
        }
        .auto-style5 {
            width: 119px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
   <%--data-dismiss="modal"--%>
                 <%--     <div class="material-datatables">
                    <table id="datatables" class="table table-striped table-no-bordered table-hover" cellspacing="0" width="100%" style="width:100%">
                      <thead>
                        <tr>
                          <th>Name</th>
                          <th>Position</th>
                          <th>Office</th>
                          <th>Age</th>
                          <th>Date</th>
                          <th class="disabled-sorting text-right">Actions</th>
                        </tr>
                      </thead>
                      <tfoot>
                        <tr>
                          <th>Name</th>
                          <th>Position</th>
                          <th>Office</th>
                          <th>Age</th>
                          <th>Start date</th>
                          <th class="text-right">Actions</th>
                        </tr>
                      </tfoot>
                      <tbody id="datatables1">
                        <tr>                                                   
                          <td class="text-right">
                            <a href="#" class="btn btn-link btn-info btn-just-icon like"><i class="material-icons">favorite</i></a>
                            <a href="#" class="btn btn-link btn-warning btn-just-icon edit"><i class="material-icons">dvr</i></a>
                            <a href="#" class="btn btn-link btn-danger btn-just-icon remove"><i class="material-icons">close</i></a>
                          </td>
                        </tr>                      
                      </tbody>
                    </table>
                  </div>
                </div>
                <!-- end content-->
              </div>
              <!--  end card  -->
            </div>
            <!-- end col-md-12 -->
          </div>
          <!-- end row -->
        </div>
      </div>--%>
    <div class="content">   
              <div class="col-md-12">
                <div class="card">
                  <div class="card-header card-header-icon card-header-rose">
                    <div class="card-icon">
                      <i class="material-icons">assignment</i>
                    </div>
                    <h4 class="card-title "> Usuarios del Sistema</h4>
                  </div>
                    <br />
                     <asp:Button class="btn btn-primary col-md-3 ml-auto" ID="Button1" runat="server" alling="Center" Text="+ USUARIO" OnClick="Btn_redirije_Click" />
                    <br />
                    <div class="card-body table-full-width table-hover">
                    <div class="table-responsive">
                      <table class="table">                       
                        <tbody>

                          <asp:GridView ID="Grid_usuarios" CssClass="table table-striped table-no-bordered table-hover" runat="server" AutoGenerateColumns="False" DataKeyNames="Cedula" DataSourceID="SqlDataUsuario" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="Grid_usuarios_SelectedIndexChanged">
                              <Columns>
                                  <asp:CommandField ShowSelectButton="True" HeaderText="Editar" SelectText="&lt;i style = &#39;color: orange&#39;class=&#39;fas fa-user-edit fa-2x&#39;&gt;&lt;/i&gt;"></asp:CommandField>
                                  <asp:BoundField DataField="Cedula" HeaderText="Cedula" ReadOnly="True" SortExpression="Cedula"></asp:BoundField>
                                  <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
                                  <asp:BoundField DataField="Primer Apellido" HeaderText="Primer Apellido" SortExpression="Primer Apellido"></asp:BoundField>
                                  <asp:BoundField DataField="Segundo Apellido" HeaderText="Segundo Apellido" SortExpression="Segundo Apellido"></asp:BoundField>
                                  <asp:BoundField DataField="Nombre Usuario" HeaderText="Nombre Usuario" SortExpression="Nombre Usuario"></asp:BoundField>
                                  <asp:BoundField DataField="Correo Electronico" HeaderText="Correo Electronico" SortExpression="Correo Electronico"></asp:BoundField>
                                  <asp:BoundField DataField="Rol" HeaderText="Rol" SortExpression="Rol"></asp:BoundField>
                                  <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado"></asp:BoundField>
                              </Columns>

                              <EditRowStyle BorderStyle="None" HorizontalAlign="Center" VerticalAlign="Middle"></EditRowStyle>
                                    <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <SelectedRowStyle BackColor="#CC6699" HorizontalAlign="Center" VerticalAlign="Middle" />
                          </asp:GridView>

                        </tbody>
                      </table>
                    </div>
                  </div>
                </div>
              </div>
            </div>       
    <asp:SqlDataSource ID="SqlDataUsuario" runat="server" ConnectionString='<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>' SelectCommand="select cedula_usuario as [Cedula], nombre_usuario as [Nombre], apellido1 as [Primer Apellido],
 apellido2 as [Segundo Apellido], nick_name as [Nombre Usuario],correo_electronico as [Correo Electronico],
 rol as [Rol], estado as [Estado]  from tb_Usuarios_Los_negritos"></asp:SqlDataSource>
    <script src="assets/js/plugins/jquery.datatables.min.js"></script>
        <%--Modal para cargar los datos que se van a actualizar --%>
    <div class="modal fade" id="ModalUsuarios" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">¿Desea Modificar este Usuario?</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                <img src="assets/img/default-avatar.png" width="150" height="150">
                    <br>
                        <div class="row">
                      <label class="col-sm-2 col-form-label">Numero de cedula</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                         <asp:TextBox ID="txt_cedula" runat="server" class="form-control" ReadOnly="True"></asp:TextBox>
                       
                          <span class="bmd-help">A block of help text that breaks onto a new line.</span>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Nombre</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                         <asp:TextBox ID="txt_nombre" runat="server" class="form-control"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Primer Pellido</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                         <asp:TextBox ID="txt_apellido1" runat="server" class="form-control"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                     <div class="row">
                      <label class="col-sm-2 col-form-label">segundo Apellido</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                          <asp:TextBox ID="txt_apellido2" runat="server" class="form-control"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                    <div class="row">
                      <label class="col-sm-2 col-form-label">Nombre de usuario</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                          <asp:TextBox ID="txt_nickname" runat="server" class="form-control"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                     <div class="row">
                      <label class="col-sm-2 col-form-label">Correo Electronico</label>
                      <div class="col-sm-10">
                        <div class="form-group">
                         <asp:TextBox ID="txt_correo" runat="server" class="form-control"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                    Estado:
                      <asp:DropDownList ID="dptestado" runat="server"  class="selectpicker" data-style="btn btn-primary btn-round" title="selecione el estado">
                          <asp:ListItem Value="Activo">Activo</asp:ListItem>
                          <asp:ListItem Value="Inactivo">Inactivo</asp:ListItem>
                      </asp:DropDownList>
                    <div class="modal-footer">
                        <asp:Button ID="btn_modificar_usuarios" class="btn btn-success" runat="server" Text="Modificar" OnClick="btn_modificar_usuarios_Click" />
                        <%--data-dismiss="modal"--%>
                        <button type="button"  class="btn btn-danger" data-dismiss="modal">Cancelar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
     <script type="text/javascript"> 
            function mensajeDeconfirmacion() {
                swal.fire({
                    title: "¡EXITO!",
                    text: "¡" + "Los Datos se Modificaron Con Exito" + "!",
                    type: 'success',
                    allowOutsideClick: false,
                }).then((result) => {
                    if (result.value) {
                        window.setTimeout('location.href="Ver_Usuarios.aspx"')
                  
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
