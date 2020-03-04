﻿using System;
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

        }

        protected void btn_Extraccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File_XML_Extraccion.HasFile)

                {
                    //this.Label2.Text = "Debe cargar un archivo XML para continuar";
                }
                else {
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
    }
}