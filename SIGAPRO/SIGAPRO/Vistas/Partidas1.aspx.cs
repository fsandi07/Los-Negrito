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
    public partial class Partidas1 : System.Web.UI.Page
    {

        private Partida partidaIn;
        private Partida_Helper partidahelperIn;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Pago_Cola_Click(object sender, EventArgs e)
        {

            try
            {

                this.partidaIn = new Partida();
                this.partidaIn.Opc = 1;
                this.partidaIn.Numero_partida = this.txt_numero_partida.Text;
                this.partidaIn.Descripcion = this.txt_descripcion.Text;
                this.partidaIn.Fecha_inicio = fechainicio.Value;
                this.partidaIn.Fecha_final = fechafinal.Value;
                this.partidaIn.Perido = int.Parse(this.Dptyear.SelectedValue);
                this.partidaIn.Estado = "Activo";

                this.partidahelperIn = new Partida_Helper(partidaIn);
                this.partidahelperIn.Agrergar_partida();

                this.txt_numero_partida = null;
                this.txt_descripcion = null;               
               ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
               

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }






        }
    }
}