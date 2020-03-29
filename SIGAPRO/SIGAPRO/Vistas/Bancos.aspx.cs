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
    public partial class Bancos : System.Web.UI.Page
    {
        private Banco bank;
        private bancoHelper bankHelper;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_redirije_Click(object sender, EventArgs e)
        {
            try
            {
                this.bank = new Banco();
                this.bank.Opc = 1;
                this.bank.Nombre_banco = this.txt_nombre_banco.Text;
                this.bank.Descripcion1 = this.txt_descripcion.Text;
                this.bank.Cuenta_iban = this.txt_cuenta_iban.Text;
                this.bank.Estado = "Activo";

                this.bankHelper = new bancoHelper(bank);
                this.bankHelper.Agrergar_Bancos();

                this.txt_nombre_banco.Text = null;
                this.txt_descripcion.Text = null;
                this.txt_cuenta_iban.Text = null;
             
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }




        }
    }
}