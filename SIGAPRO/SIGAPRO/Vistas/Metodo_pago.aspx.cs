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
    public partial class Metodo_pago : System.Web.UI.Page

    {
        private Metodo_pagos metodo;
        private Metodo_pago_Helper metodoHelper;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_redirije_Click(object sender, EventArgs e)
        {
            try
            {
                this.metodo = new Metodo_pagos();
                this.metodo.Opc = 1;
                this.metodo.Nombre_metodo = this.txt_nombre_metodo.Text;
                this.metodo.Descripcion_metodo = this.txt_descripcion.Text;
                this.metodo.Num_referencia = this.txt_creferencia.Text;
                this.metodo.Estado = "Activo";
                this.metodoHelper = new Metodo_pago_Helper(metodo);
                this.metodoHelper.Agregar_metodo_pago();
                this.txt_nombre_metodo.Text = null;
                this.txt_descripcion.Text = null;
                this.txt_creferencia.Text = null;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }


        }
    }
}