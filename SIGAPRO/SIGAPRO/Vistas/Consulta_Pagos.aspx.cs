using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGAPRO.NEGOCIO;
using System.Data;

namespace SIGAPRO.Vistas
{
    public partial class Consulta_Pagos : System.Web.UI.Page
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


                    e.Row.Cells[1].Text = "<i style='color: green' class='fas fa-exclamation-triangle'></i>" + "Pagada" + e.Row.Cells[1].Text;

                }
                else
                {
                    DateTime fecha_actual = DateTime.Today;
                    // obtinene el dia de la fecha actual=fecha_actual.ToString("dd")                  
                    DateTime fecha = DateTime.Parse(e.Row.Cells[4].Text);
                    int mes_ingreso = int.Parse(e.Row.Cells[4].Text.Substring(5, 2));
                    DateTime fecha_final = fecha.AddDays(dias_plazo);
                    TimeSpan tiempoDiferencia =  fecha_final- fecha_actual;
                    int aux = tiempoDiferencia.Days;
                    // con este if hago que si el resultado de la resta anterior ya sea mayor a 3 coloque una alerta de color amarrilo.
                    if (aux > 10)
                    {
                        e.Row.Cells[1].Text = "<i style='color: yellow' class='fas fa-exclamation-triangle'></i>" + aux +" "+"Dias para el pago" + e.Row.Cells[1].Text;
                    }
                    // si el el resultado es menor o igual a 3 la alerta es de color rojo. 
                    else if (aux <= 10)
                    {
                        e.Row.Cells[1].Text = "<i style='color: red' class='fas fa-exclamation-triangle'></i>" + aux +" "+"Dias para el pago" + e.Row.Cells[1].Text;
                    }
                }
            }

        }
    }
}