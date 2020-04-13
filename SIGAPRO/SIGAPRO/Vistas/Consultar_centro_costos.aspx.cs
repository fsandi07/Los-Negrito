using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGAPRO.NEGOCIO;

namespace SIGAPRO.Vistas
{
    public partial class Consultar_centro_costos : System.Web.UI.Page
    {
        private centro_de_costos CCostos;
        private Centro_de_costos_Helper CCHELPER;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_redirije_Click(object sender, EventArgs e)
        {
            Response.Redirect("Centro_de_Costos.aspx");
        }

        protected void grid_centro_de_costos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalCentroCostos", "$('#ModalCentroCostos').modal();", true);
            this.txt_centro_de_costos.Text = this.grid_centro_de_costos.Rows[grid_centro_de_costos.SelectedIndex].Cells[1].Text;
            this.txt_descripcion.Text = this.grid_centro_de_costos.Rows[grid_centro_de_costos.SelectedIndex].Cells[2].Text;
           this.dpt_estado.SelectedValue = this.grid_centro_de_costos.Rows[grid_centro_de_costos.SelectedIndex].Cells[3].Text;
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CCostos = new centro_de_costos();
                this.CCostos.Numero_centro_costos = this.txt_centro_de_costos.Text;
                this.CCostos.Descripcion = this.txt_descripcion.Text;
                this.CCostos.Estado = this.dpt_estado.SelectedValue;
                this.CCostos.Opc = 2;
                this.CCHELPER = new Centro_de_costos_Helper(CCostos);
                this.CCHELPER.Modificar_centro_costos();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
    }
}