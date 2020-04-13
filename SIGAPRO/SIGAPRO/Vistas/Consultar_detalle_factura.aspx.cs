using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGAPRO.NEGOCIO;

namespace SIGAPRO.Vistas
{
    public partial class Consultar_detalle_factura : System.Web.UI.Page
    {
        private Clasificacion_Factura CFactura;
        private Clasificacion_Factura_Helper CFacturaHelper;
        public static string id;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_redirije_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ingresar_detalle_Facturas.aspx");
        }

        protected void grid_detalle_factura_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalDetalleFactura", "$('#modalDetalleFactura').modal();", true);
            id= this.grid_detalle_factura.Rows[grid_detalle_factura.SelectedIndex].Cells[1].Text;
            Page.Server.HtmlDecode(this.txt_nombre_detalle.Text= this.grid_detalle_factura.Rows[grid_detalle_factura.SelectedIndex].Cells[2].Text);
            Page.Server.HtmlDecode(this.txt_descripcion_detalle.Text= this.grid_detalle_factura.Rows[grid_detalle_factura.SelectedIndex].Cells[3].Text);
            this.dpt_estado.SelectedValue= this.grid_detalle_factura.Rows[grid_detalle_factura.SelectedIndex].Cells[4].Text;
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CFactura = new Clasificacion_Factura();
                this.CFactura.Id_detalle = int.Parse(id);
                this.CFactura.Nombre_clasificacion = this.txt_nombre_detalle.Text;
                this.CFactura.Descripcion_clasificacion = this.txt_descripcion_detalle.Text;
                this.CFactura.Estado_detalle = dpt_estado.SelectedValue;
                this.CFactura.Opc = 2;
                this.CFacturaHelper = new Clasificacion_Factura_Helper(CFactura);
                this.CFacturaHelper.Modificar_detalle_factura();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);

            }
        }
    }
}