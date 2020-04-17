using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGAPRO.NEGOCIO;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace SIGAPRO.Vistas
{
    public partial class Consulta_Pagos : System.Web.UI.Page
    {
        private DatosXML datos_Del_XML;
        private DataTable datos;
        private XMLHELPER XMLHELPER;
        private Egreso_manual Egre;
        private Egreso_Manual_Helper EgreHelper;
        private Metodo_pagos Metodo;
        private Metodo_pago_Helper MetodoHelper;
        private Clasificacion_Factura detalle;
        private Clasificacion_Factura_Helper detalleHelper;
        private static int GloID;
        private static byte[] pdfbytes;
        private static string estado;
        private Banco bancos;
        private bancoHelper bancoshelper;
        private string nombre_banco;
        private int id_banco;
        private int id_metodo;
        private int id_detalle;
        private string nombre_metodo;
        private string nombre_detalle;
        private int dias_faltantes;


        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Extraccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File_XML_Extraccion.HasFile)

                {
                    //this.Label2.Text = "Debe cargar un archivo XML para continuar";
                }
                else
                {
                    this.datos_Del_XML = new DatosXML();
                    this.datos_Del_XML.Xml = File_XML_Extraccion.FileBytes;
                    this.datos_Del_XML.Opc = 1;
                    this.XMLHELPER = new XMLHELPER(datos_Del_XML);
                    this.XMLHELPER.enviarxml();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera", "mensajeEspera('" + "" + "');", true);
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        protected void btnExtraccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Extracion_de_XML.aspx");
        }

        protected void btnManual_Click(object sender, EventArgs e)
        {
            Response.Redirect("Egreso_Manual.aspx");
        }

        protected void GridVegreso_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int dias_plazo = int.Parse(e.Row.Cells[14].Text);
                string estado = e.Row.Cells[13].Text;
                if (estado == "Si")
                {


                    e.Row.Cells[23].Text = "<i style='color: green' class='fas fa-exclamation-triangle'></i>" +" " +"Pagada" + e.Row.Cells[23].Text;

                }
                else
                {
                    DateTime fecha_actual = DateTime.Today;
                    // obtinene el dia de la fecha actual=fecha_actual.ToString("dd")                  
                    DateTime fecha = DateTime.Parse(e.Row.Cells[4].Text);
                    int mes_ingreso = int.Parse(e.Row.Cells[4].Text.Substring(5, 2));
                    DateTime fecha_final = fecha.AddDays(dias_plazo);
                    TimeSpan tiempoDiferencia = fecha_final - fecha_actual;
                    int aux = tiempoDiferencia.Days;
                    dias_faltantes = aux;
                    // con este if hago que si el resultado de la resta anterior ya sea mayor a 3 coloque una alerta de color amarrilo.
                    if (aux > 10)
                    {
                        e.Row.Cells[23].Text = "<i style='color: yellow' class='fas fa-exclamation-triangle'></i>" + " " + aux + " " + "Dias" +  e.Row.Cells[23].Text;
                    }
                    // si el el resultado es menor o igual a 3 la alerta es de color rojo. 
                    else if (aux <= 10)
                    {
                        e.Row.Cells[23].Text = "<i style='color: red' class='fas fa-exclamation-triangle'></i>" + " " + aux +" "+"Dias" + e.Row.Cells[23].Text;
                    }
                }
            }
        }

        protected void GridVegreso_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "PDF")
                {

                    int index = int.Parse(e.CommandArgument.ToString());
                    GloID = int.Parse(GridVegreso.DataKeys[index].Value.ToString());                   
                    AbrirPdf();

                }
                else if (e.CommandName == "Ver")
                {
                    int index = int.Parse(e.CommandArgument.ToString());
                    GloID = int.Parse(GridVegreso.DataKeys[index].Value.ToString());
                    this.LblComprobante.Text = GloID.ToString();
                    buscaegreso();
                    this.Lbldias_faltantes.Text =dias_faltantes.ToString();
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalDocumentos", "$('#ModalDocumentos').modal();", true);
                }

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        private void AbrirPdf()
        {
            try
            {
                // hacer una entidad antes de hacer este using


                using (SIGAPRO.Entidadengres.DB_A4DE45_SIGEDOCEgreso db = new SIGAPRO.Entidadengres.DB_A4DE45_SIGEDOCEgreso())
                {
                    var oDocument = db.tb_Egreso_Manual_los_negritos.Find(GloID);
                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    string fullFilePath = folder + oDocument.Nombre_pdf;
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                    File.WriteAllBytes(fullFilePath, oDocument.Pdf_factura);
                    Byte[] bytes = oDocument.Pdf_factura;

                    Process.Start(fullFilePath);
               
                }

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeErrorPDF", "mensajeErrorPDF('" + "" + "');", true);
            }

        }
        public void buscaegreso()
        {
            try
            {
                this.Egre = new Egreso_manual();
                this.Egre.Opc = 2;
                this.Egre.Id_egreso = GloID;
                this.EgreHelper = new Egreso_Manual_Helper(Egre);
                this.datos = new DataTable();
                this.datos = this.EgreHelper.Consulta_Egreso();
                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    this.Lbldigiomanu.Text = fila["Digital"].ToString();
                    this.Lblfecha.Text = fila["Fecha_ingreso"].ToString();
                    this.Lblnumfactura.Text = fila["Numero_factura"].ToString();
                    this.LblID_comercio.Text = fila["Cedula_Juridica"].ToString();
                    this.Lblfisica.Text = fila["Existe_fisica"].ToString();
                    this.LblGTI.Text = fila["GTI"].ToString();
                    this.Lblcomercio.Text = fila["Nombre_comercio"].ToString();
                    id_detalle = int.Parse(fila["Id_detalle"].ToString());
                    buscadetalle();
                    this.Lbldetalle.Text = nombre_detalle;
                    this.Lblpartida.Text = fila["Id_partida"].ToString();
                    this.Lblmonto_total.Text = fila["Monto_factura"].ToString();
                    this.Lblestadopago.Text = fila["Estado_pago"].ToString();
                    this.Lblplazo_pago.Text = fila["Plazo_pago"].ToString();
                    pdfbytes = Encoding.ASCII.GetBytes(fila["Pdf_factura"].ToString()); 
                    this.LBLNombrepdf.Text = fila["Nombre_pdf"].ToString();
                    this.LblCenCos.Text = fila["Id_Centro_costos"].ToString();
                    id_metodo= int.Parse(fila["Id_metodo_pago"].ToString());
                    buscaMetodo();
                    this.LblMetodoPago.Text = nombre_metodo;
                    id_banco = int.Parse(fila["Id_banco"].ToString());
                    buscaBanco();
                    this.LblBanco.Text = nombre_banco;
                    this.LblMoneda.Text = fila["Moneda"].ToString();
                    this.Lbltipo_cambio.Text = fila["Tipo_cambio"].ToString();//
                    this.Lblmes.Text = fila["Mes"].ToString();
                    this.Lbltotal_iva.Text = fila["TotalIva"].ToString();
                     estado = fila["Estado"].ToString();             

                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
        public void buscaBanco()
        {
            try
            {
                this.bancos = new Banco();
                this.bancos.Opc = 3;
                this.bancos.Id_banco = id_banco;
                this.bancoshelper = new bancoHelper(bancos);
                this.datos = new DataTable();
                this.datos = this.bancoshelper.Consulta_Bancos();
                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    nombre_banco = fila["nombre_banco"].ToString();
                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
        public void buscaMetodo()
        {
            try
            {
                this.Metodo = new Metodo_pagos();
                this.Metodo.Opc = 2;
                this.Metodo.Id_metodo = id_metodo;
                this.MetodoHelper = new Metodo_pago_Helper(Metodo);               
                this.datos = new DataTable();
                this.datos = this.MetodoHelper.Buscar_metodo(); ;
                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    nombre_metodo = fila["Nombre"].ToString();
                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        public void buscadetalle()
        {
            try
            {
                this.detalle = new Clasificacion_Factura();
                this.detalle.Opc = 4;
                this.detalle.Id_detalle = id_detalle;
                this.detalleHelper = new Clasificacion_Factura_Helper(detalle);               
                this.datos = new DataTable();
                this.datos = this.detalleHelper.Buscar_detalle() ;
                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    nombre_detalle = fila["nombre_detalle"].ToString();
                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        protected void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_nombre.Text != "") {
                try
                {
                    SqlDataEgreso.SelectCommand = "SELECT * FROM [tb_Egreso_Manual_los_negritos] where Numero_factura like '%" + this.txt_nombre.Text + "%'";
                    SqlDataEgreso.DataBind();

                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }

            }
            else
            {
                try
                {
                    SqlDataEgreso.SelectCommand = " SELECT * FROM [tb_Egreso_Manual_los_negritos]";
                    SqlDataEgreso.DataBind();
                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }

            }
        }

        protected void DptMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.DptMes.SelectedValue != "Seleccionar") {
                try
                {
                    SqlDataEgreso.SelectCommand = "SELECT * FROM [tb_Egreso_Manual_los_negritos] where Mes= " + this.DptMes.SelectedValue + "";
                    SqlDataEgreso.DataBind();

                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }

            }
            else
            {
                try
                {
                    SqlDataEgreso.SelectCommand = " SELECT * FROM [tb_Egreso_Manual_los_negritos]";
                    SqlDataEgreso.DataBind();
                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }

            }
        }

        protected void Dptestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Dptestado.SelectedValue!="Seleccionar")
            {
                try
                {
                    SqlDataEgreso.SelectCommand = "SELECT * FROM [tb_Egreso_Manual_los_negritos] where Estado_pago like '%" + this.Dptestado.SelectedValue + "%'";
                    SqlDataEgreso.DataBind();

                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }

            }
            else
            {
                try
                {
                    SqlDataEgreso.SelectCommand = " SELECT * FROM [tb_Egreso_Manual_los_negritos]";
                    SqlDataEgreso.DataBind();
                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }

            }
        }

     

        protected void TxtPartida_TextChanged(object sender, EventArgs e)
        {
            if (this.TxtPartida.Text != "")
            {

                try
                {
                    SqlDataEgreso.SelectCommand = "SELECT * FROM [tb_Egreso_Manual_los_negritos] where Id_partida like '%" + this.TxtPartida.Text + "%'";
                    SqlDataEgreso.DataBind();
                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }
            }
            else {
                try
                {
                    SqlDataEgreso.SelectCommand = " SELECT * FROM [tb_Egreso_Manual_los_negritos]";
                    SqlDataEgreso.DataBind();
                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
                }

            }

        }

        protected void GridVegreso_SelectedIndexChanged(object sender, EventArgs e)
        {
              GloID = int.Parse(GridVegreso.DataKeys[2].Value.ToString());
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal100", "$('#myModal100').modal();", true);
        }
    }
}