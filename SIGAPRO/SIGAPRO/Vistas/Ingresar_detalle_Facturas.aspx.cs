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
    public partial class Ingresar_detalle_Facturas : System.Web.UI.Page
    {
        private Clasificacion_Factura CFactura;
        private Clasificacion_Factura_Helper CFacturaHelper;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_redirije_Click(object sender, EventArgs e)
        {
            try
            {
                this.CFactura = new Clasificacion_Factura();
                this.CFactura.Opc = 1;
                this.CFactura.Nombre_clasificacion = this.txt_nombre_detalle.Text;
                this.CFactura.Descripcion_clasificacion = this.txt_descripcion_detalle.Text;
                this.CFactura.Estado_detalle = "Activo";

                this.CFacturaHelper = new Clasificacion_Factura_Helper(CFactura);
                this.CFacturaHelper.Agrergar_Clasificacion_factura();
                this.txt_nombre_detalle.Text = null;
                this.txt_descripcion_detalle.Text = null;                
                
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                Response.Redirect("Consultar_detalle_factura.aspx");

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
    }
}