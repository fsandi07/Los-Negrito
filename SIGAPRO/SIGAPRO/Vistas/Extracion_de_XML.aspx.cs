using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using SIGAPRO.NEGOCIO;
using System.Data;

namespace SIGAPRO.Vistas
{
    public partial class Extracion_de_XML : System.Web.UI.Page
    {
        private DatosXML datos_Del_XML;
        private DataTable datos;
        private XMLHELPER XMLHELPER;
        protected void Page_Load(object sender, EventArgs e)
        {
                      listarXML();

            if (txt_plazo_credito.Text == "0") {
                this.DptBanco.Enabled = true;
                this.DptMetodoPago.Enabled = true;
            
            }
        }
        //protected void btn_Extraccion_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!File_XML_Extraccion.HasFile)

        //        {
        //            //this.Label2.Text = "Debe cargar un archivo XML para continuar";
        //        }
        //        else
        //        {
        //            this.datos_Del_XML = new DatosXML();
        //            this.datos_Del_XML.Xml = File_XML_Extraccion.FileBytes;
        //            this.datos_Del_XML.Opc = 1;
        //            this.XMLHELPER = new XMLHELPER(datos_Del_XML);
        //            this.XMLHELPER.enviarxml();
        //            ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera", "mensajeEspera('" + "" + "');", true);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
        //    }
        //}


        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consulta_Pagos.aspx");
        }

        private void listarXML()
            {

            try
            {
                this.datos_Del_XML = new DatosXML();
                this.datos_Del_XML.Opc = 1;
                this.XMLHELPER = new XMLHELPER(datos_Del_XML);
                this.datos = new DataTable();
                this.datos = this.XMLHELPER.mostrarxml();

                if (datos.Rows.Count >= 0)
                {

                    DataRow fila = datos.Rows[0];
                    this.txt_fecha_emision.Text = fila["fecha_de_emison"].ToString();
                    this.txt_numero_factura.Text = fila["numero_factura"].ToString();
                    this.txt_nombre_comercio.Text = fila["nombre_comercio"].ToString();
                    this.txt_cedula_juridica.Text = fila["cedula_juridica"].ToString();
                    if (fila["Plazo_credito"].ToString() == "")
                    {
                        this.txt_plazo_credito.Text = 0.ToString();

                    }
                    else
                    {

                        this.txt_plazo_credito.Text = fila["Plazo_credito"].ToString();

                    }
                    this.txt_total_iva.Text = fila["total_IVA"].ToString();
                    this.txt_total_pagar.Text = fila["total_pagar"].ToString();
                }
               BorrarXML();
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);

            }

        }


        private void BorrarXML()
        {

            try
            {
                this.datos_Del_XML = new DatosXML();
                this.datos_Del_XML.Opc = 2;
                this.datos_Del_XML.NumFactura = this.txt_numero_factura.Text;
                this.XMLHELPER = new XMLHELPER(datos_Del_XML);
                this.XMLHELPER.borrarxml();
            }
            catch (Exception ex)
            {
               

            }

        }

    }
}