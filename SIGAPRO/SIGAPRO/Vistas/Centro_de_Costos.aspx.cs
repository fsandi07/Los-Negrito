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
    public partial class Centro_de_Costos : System.Web.UI.Page
    {
        private centro_de_costos CCostos;
        private Centro_de_costos_Helper CCHELPER;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Pago_Cola_Click(object sender, EventArgs e)
        {
            try
            {
                this.CCostos = new centro_de_costos();
                this.CCostos.Opc = 1;
                this.CCostos.Numero_centro_costos = this.txt_centro_de_costos.Text;
                this.CCostos.Descripcion = this.txt_descripcion.Text;
                this.CCostos.Estado = "Activo";
                this.CCHELPER = new Centro_de_costos_Helper(CCostos);
                this.CCHELPER.Agrergar_centro_costos();
                this.txt_centro_de_costos.Text = null;
                this.txt_descripcion.Text = null;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                Response.Redirect("Consultar_centro_costos.aspx");

            }
            catch (Exception )
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
    }
}