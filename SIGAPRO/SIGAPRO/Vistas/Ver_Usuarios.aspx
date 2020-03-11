<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Ver_Usuarios.aspx.cs" Inherits="SIGAPRO.Vistas.Ver_Usuarios"  validaterequest="false" %>
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
     
   <%-- <div class="content">
        <div class="container-fluid">
          <div class="row">
            <div class="col-md-12">
              <div class="card">
                <div class="card-header card-header-primary card-header-icon">
                  <div class="card-icon">
                    <i class="material-icons">assignment</i>
                  </div>
                  <h4 class="card-title">DataTables.net</h4>
                </div>
                <div class="card-body">
                  <div class="toolbar">
                    <!--        Here you can write extra buttons/actions for the toolbar              -->
                  </div>
                    <%--<div id="datatables_filter" class="dataTables_filter"><label><input type="search" class="form-control form-control-sm" placeholder="Search records" aria-controls="datatables"></label></div>--%>
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
                  <div class="card-body table-full-width table-hover">
                      <div id="datatables_filter" class="dataTables_filter"><label><input type="search" class="form-control form-control-sm" placeholder="Search records" aria-controls="datatables"></label></div>
                    <div class="table-responsive">
                      <table class="table">
                        <thead class="">
                          <th class="auto-style4">
                            ID
                          </th>
                          <th class="auto-style1">                                                   
                            Name
                          </th>
                          <th class="auto-style2">
                            Country
                          </th>
                          <th class="auto-style5">
                            City
                          </th>
                          <th>
                            Salary
                          </th>
                        </thead>
                        <tbody>

         <asp:gridview runat="server" cssclass="table table-striped table-no-bordered table-hover" autogeneratecolumns="False" datakeynames="cedula_usuario" datasourceid="SqlDataSource1" enablepersistedselection="True" AllowPaging="True">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="cedula_usuario" HeaderText="cedula_usuario" ReadOnly="True" SortExpression="cedula_usuario" />
            <asp:BoundField DataField="nombre_usuario" HeaderText="nombre_usuario" SortExpression="nombre_usuario" />
            <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
            <asp:BoundField DataField="nick_name" HeaderText="nick_name" SortExpression="nick_name" />
            <asp:BoundField DataField="correo_electronico" HeaderText="correo_electronico" SortExpression="correo_electronico" />
        </Columns>
    </asp:gridview>

                        </tbody>
                      </table>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB_A4DE45_SIGEDOCConnectionString2 %>" SelectCommand="SELECT [cedula_usuario], [nombre_usuario], [apellido1], [nick_name], [correo_electronico] FROM [tb_Usuarios_Los_negritos]"></asp:SqlDataSource>
      <script src="assets/js/plugins/jquery.datatables.min.js"></script>
</asp:Content>
