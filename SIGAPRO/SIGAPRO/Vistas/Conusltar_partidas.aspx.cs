using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGAPRO.NEGOCIO;

namespace SIGAPRO.Vistas
{
    public partial class Conusltar_partidas : System.Web.UI.Page
    {
        private Partida partidaIn;
        private Partida_Helper partidahelperIn;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_redirije_Click(object sender, EventArgs e)
        {
            Response.Redirect("Partidas1.aspx");
        }

        protected void Grid_Partidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "Modal_Partidas", "$('#Modal_Partidas').modal();", true);
            this.txt_numero_partida.Text = this.Grid_Partidas.Rows[Grid_Partidas.SelectedIndex].Cells[1].Text;
            this.txt_descripcion.Text = this.Grid_Partidas.Rows[Grid_Partidas.SelectedIndex].Cells[2].Text;
            this.txt_fecha_inicio.Text=this.Grid_Partidas.Rows[Grid_Partidas.SelectedIndex].Cells[3].Text;
            this.txt_fecha_final.Text= this.Grid_Partidas.Rows[Grid_Partidas.SelectedIndex].Cells[4].Text;
            this.dptestado.SelectedValue= this.Grid_Partidas.Rows[Grid_Partidas.SelectedIndex].Cells[5].Text;
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.partidaIn = new Partida();
                this.partidaIn.Numero_partida = this.txt_numero_partida.Text;
                this.partidaIn.Descripcion = this.txt_descripcion.Text;
                this.partidaIn.Fecha_inicio = fechainicio.Value;
                this.partidaIn.Fecha_final = fechafinal.Value;
                this.partidaIn.Estado = dptestado.SelectedValue;
                this.partidaIn.Opc = 2;
                this.partidahelperIn = new Partida_Helper(partidaIn);
                this.partidahelperIn.Modificar_Partida();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
    }
}