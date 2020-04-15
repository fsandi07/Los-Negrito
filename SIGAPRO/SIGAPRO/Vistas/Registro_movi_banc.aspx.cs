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
    public partial class Registro_movi_banc : System.Web.UI.Page
    {
        private Movimientos_Bancarios MoviBanck;
        private Movimientos_bancarios_Helper MoviBanckHelp;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_redirije_Click(object sender, EventArgs e)
        {
            try
            {
                this.MoviBanck = new Movimientos_Bancarios();
                this.MoviBanck.Opc = 1;
                this.MoviBanck.Id_banco = this.DptBanco.SelectedValue;
                this.MoviBanck.Moneda = this.DptMoneda.SelectedValue;
                this.MoviBanck.Fecha_registro = fecha.Value;
                this.MoviBanck.Nombre_movi = this.txt_nombre_banco.Text;
                this.MoviBanck.Detalle_movi = this.txt_descripcion.Text;

                this.MoviBanckHelp = new Movimientos_bancarios_Helper(MoviBanck);
                this.MoviBanckHelp.Agregar_movi_banc();

                this.txt_descripcion.Text = null;
                this.txt_nombre_banco.Text = null;
                this.DptBanco.SelectedValue = null;
                this.DptMoneda.SelectedValue = null;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);

            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
    }
}