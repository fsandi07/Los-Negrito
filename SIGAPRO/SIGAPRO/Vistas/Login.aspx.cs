using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using SIGAPRO.NEGOCIO;

namespace SIGAPRO.Vistas
{
    public partial class Login : System.Web.UI.Page
    {
        private DataTable datos;
        private Usuarios usuarios;
        private UsuariosHelper usuariosHelper;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuarios = new Usuarios();
                this.usuarios.Nick_name = this.Txt_Usuario.Text;
                this.usuarios.Clave_usuario = this.Txt_clave.Text;
                this.usuarios.Opc = 1;
                this.usuariosHelper = new UsuariosHelper(usuarios);
                this.datos = new DataTable();
                this.datos = this.usuariosHelper.validarusuario();
                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
          
                    Response.Redirect("inicio.aspx");

                }



            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }



        }
    }
}