using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using SIGAPRO.NEGOCIO;

namespace SIGAPRO.Vistas
{
    public partial class Datos_del_XML : System.Web.UI.Page
    {
        private DatosXML datos_Del_XML;
        private DataTable datos;
        private XMLHELPER XMLHELPER;
        protected void Page_Load(object sender, EventArgs e)
        {
            listarXML();
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

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }


    }
}