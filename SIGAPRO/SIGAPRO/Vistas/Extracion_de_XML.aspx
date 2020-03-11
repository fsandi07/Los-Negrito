﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="Extracion_de_XML.aspx.cs" Inherits="SIGAPRO.Vistas.Extracion_de_XML" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="bower_components/chartist/dist/chartist.min.css">

    <%-- links para las alertas  --%>
    <script type="text/javascript" src="jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="sweetalert/sweetalert2.min.css">
    <script type="text/javascript" src="sweetalert/sweetalert2.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card ">
                        <div class="card-header ">
                            <h4 class="card-title">Extracción de Datos -
                    <small class="description">Facturas XML</small>
                            </h4>
                        </div>
                        <div class="card-body ">
                            <ul class="nav nav-pills nav-pills-warning" role="tablist">
                                <li class="nav-item">
                                    <a class="nav-link active" data-toggle="tab" href="#link1" role="tablist">Asignar Centro de Costos
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" data-toggle="tab" href="#link2" role="tablist">Asignar Partidas
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" data-toggle="tab" href="#link5" role="tablist">Aprobación de Factura.
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" data-toggle="tab" href="#link3" role="tablist">Buscar Archivo XML
                                    </a>
                                </li>
                            </ul>
                            <div class="tab-content tab-space">
                                <div class="tab-pane active" id="link1">
                                    Seleccione el Centro de Costos.
                                     <br />
                                    <br />
                                    <div class="col-lg-5 col-md-6 col-sm-3">
                                        <asp:DropDownList ID="DropDownList2" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar C. Costos">
                                            <asp:ListItem Value="1">Pureba1</asp:ListItem>
                                            <asp:ListItem Value="2">Prueba2</asp:ListItem>
                                            <asp:ListItem Value="3">Prueba 3</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>

                                    <br />
                                    <div>
                                    </div>
                                    <br />
                                    This is very nice.
                                </div>

                                <div class="tab-pane" id="link2">
                                    Asigne la partida correspondiente.
                                    <br />
                                    <br />
                                    <div class="col-lg-5 col-md-6 col-sm-3">
                                        <asp:DropDownList ID="DropDownList1" runat="server" class="selectpicker" data-style="btn btn-primary btn-round" title="Seleccionar Partida">
                                            <asp:ListItem Value="1">Pureba1</asp:ListItem>
                                            <asp:ListItem Value="2">Prueba2</asp:ListItem>
                                            <asp:ListItem Value="3">Prueba 3</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <br />
                                    <br />
                                    Dramatically maintain clicks-and-mortar solutions without functional solutions.
                                </div>
                                <div class="tab-pane" id="link5">
                                    La factura se encuentra aprobada por hacienda?
                                    <br />
                                    <br />                                   

                                    <div class="btn-group form-check" >
                                        <label class="btn btn-primary btn-round" >
                                            <asp:RadioButton runat="server" ID="radioB1" GroupName="radioB"  />
                                            Sí   
                                        </label>
                                     </div>
                                    <div class="btn-group form-check" >
                                        <label class="btn btn-primary btn-round" >
                                            <asp:RadioButton runat="server" ID="radioB2" GroupName="radioB" />
                                            No
   
                                        </label>
                                    </div>
                                    <br />
                                    <br />
                                    Dramatically maintain clicks-and-mortar solutions without functional solutions.
                                </div>
                                <div class="tab-pane" id="link3">
                                    Completely synergize resource taxing relationships via premier niche markets. Professionally cultivate one-to-one customer service with robust ideas.
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <br />
                                    <br />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   
                                    <br />
                                      
  <div class="form-group form-file-upload form-file-multiple">
    <input type="file" multiple="" class="inputFileHidden">
      
    <div class="input-group">
       
 <%--       <input type="text" class="form-control inputFileVisible" placeholder="Single File">--%>
         <a href="#" class="badge badge-primary"><i class="material-icons">attach_file</i>
        <span class="input-group-btn">
           
             <asp:Label ID="Label1" runat="server" Text="Precione el circulo para cargar Archivo XML"></asp:Label>
                
            <button type="button" class="btn btn-fab btn-round btn-success">
         
                 <asp:FileUpload ID="File_XML_Extraccion" runat="server"/>
          </button>
                  
        </span>
              </a> 
    </div>
  </div>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button class="btn" alligment ID="btn_Extraccion" runat="server" OnClick="btn_Extraccion_Click" Text="Extraer Datos" Width="178px" />
                                    <br />
                                    &nbsp;
                                </div>
                            </div>
                        </div>
                    </div>
                </div>



                <script type="text/javascript">
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
                    // mensaje de error
                    function mensajeError() {
                        swal.fire({
                            title: '¡Error!',
                            text: "¡" + " Lo sentimos el archivo no es de tipo XML o este XML ya fue Extraido Por Favor Verifique" + "!",
                            type: 'error',
                            showConfirmButton: false,
                            allowOutsideClick: false,
                            timer: 5000,

                        })
                    }

                </script>
</asp:Content>
