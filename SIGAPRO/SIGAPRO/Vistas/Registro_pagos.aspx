<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Registro_pagos.aspx.cs" Inherits="SIGAPRO.Vistas.Registro_pagos" %>

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
                    <label class="col-sm-2 col-form-label"><h6 class="card-title text-danger">Comprobante N°:</label>                                             
                     <asp:Label ID="Label1" class="card-title text-danger" runat="server" Text="Label">000</asp:Label>
                </div>
                <h3><span class="tim-note"></span>Ingreso</h3>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Buscar Colaborador:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <asp:DropDownList ID="DptColaborador" runat="server" class="selectpicker" data-style="select-with-transition" title="Colaborador">
                                    <asp:ListItem Value="1">Colaborador1</asp:ListItem>
                                    <asp:ListItem Value="2">Colaborador2</asp:ListItem>
                                    <asp:ListItem Value="3">Colaborador3</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Nombre:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox ID="txt_Nombre" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Apellidos:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox ID="txt_Apellido" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Salario Quincenal:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox ID="txt_Salario" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Permiso sin goce de salario:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <asp:DropDownList ID="Dptsin_goce" runat="server" class="selectpicker" data-style="select-with-transition" title="Cantidad Días">
                                    <asp:ListItem Value="1">1</asp:ListItem>
                                    <asp:ListItem Value="2">2</asp:ListItem>
                                    <asp:ListItem Value="3">3</asp:ListItem>
                                </asp:DropDownList>
                                <asp:TextBox ID="Txt_total_sin_goce" runat="server" class="form-control" placeHolder="Total sin goce" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Comisión Productividad:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox ID="txt_Comision_Productividad" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Préstamo:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox ID="txt_Prestamo" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Feriados:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <asp:DropDownList ID="Dptferiados" runat="server" class="selectpicker" data-style="select-with-transition" title="Días Feriados">
                                    <asp:ListItem Value="1">1</asp:ListItem>
                                    <asp:ListItem Value="2">2</asp:ListItem>
                                    <asp:ListItem Value="3">3</asp:ListItem>
                                </asp:DropDownList>
                                <asp:TextBox ID="txt_total_feriados" runat="server" class="form-control" placeHolder="Total feriados" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Extras:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <asp:TextBox ID="txt_horas_extras" runat="server" class="form-control" placeHolder="Cantidad Horas"></asp:TextBox>
                                <asp:TextBox ID="txt_total_Extras" runat="server" class="form-control" placeHolder="Total Extras" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <label class="col-sm-2 col-form-label"><h6 class="card-title text-warning">Salario Neto:</h6></label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox ID="Txt_Salario_Neto" runat="server" class="form-control" ReadOnly="true"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <h3><span class="tim-note"></span>Deducciones</h3>
                <div class="row">
                    <label class="col-sm-2 col-form-label">Caja del Seguro Social:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox ID="Txt_caja_seguro" runat="server" class="form-control" ></asp:TextBox>
                        </div>
                    </div>
                </div>
                  <div class="row">
                    <label class="col-sm-2 col-form-label">Impuesto Sobre la Renta:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox ID="Txt_impuesto_renta" runat="server" class="form-control" ></asp:TextBox>
                        </div>
                    </div>
                </div>
                  <div class="row">
                    <label class="col-sm-2 col-form-label">Otras deducciones:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <div class="col-lg-5 col-md-6 col-sm-3">
                                <asp:TextBox ID="txt_descrip_deduc" runat="server" class="form-control" placeHolder="Descripción de la deducción"></asp:TextBox>
                                <asp:TextBox ID="txt_total_otras_deduc" runat="server" class="form-control" placeHolder="Total otras deducciones"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                  <div class="row">
                    <label class="col-sm-2 col-form-label"><h6 class="card-title text-warning">Total Deducciones:</h6></label>
                       
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox ID="txt_total_deducciones" runat="server" class="form-control" ReadOnly="true" ></asp:TextBox>
                        </div>
                    </div>
                </div>
                <h3><span class="tim-note"></span>Totales</h3>
                 <div class="row">
                    <label class="col-sm-2 col-form-label">Total depositado:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox ID="txt_total_depositado" runat="server" class="form-control" ReadOnly="true" ></asp:TextBox>
                        </div>
                    </div>
                </div>
                 <div class="row">
                    <label class="col-sm-2 col-form-label">Saldo Anterior:</label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox ID="txt_saldo_anterior" runat="server" class="form-control" ReadOnly="true" ></asp:TextBox>
                        </div>
                    </div>
                </div>
                 <div class="row">
                    <label class="col-sm-2 col-form-label"><h6 class="card-title text-warning">Saldo:</h6></label>
                    <div class="col-sm-10">
                        <div class="form-group">
                            <asp:TextBox ID="txt_saldo" runat="server" class="form-control" ReadOnly="true" ></asp:TextBox>
                        </div>
                    </div>
                </div>
                <br />
                <br />
    <asp:Button class="btn btn-success"  ID="btn_Pago_Cola" runat="server" Text="Registrar Datos" Width="178px" />




            </div>
        </div>
    </div>
</asp:Content>
