using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGAPRO.NEGOCIO;

namespace SIGAPRO.Vistas
{
    public partial class Agregar_usuarios : System.Web.UI.Page
    {
        private Usuarios usu;
        private UsuariosHelper usuariosHelper;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_agregar_usuario_Click(object sender, EventArgs e)
        {
            if (this.txt_clave1.Text==this.txt_clave2.Text)
            {

                this.usu = new Usuarios();
                this.usu.Cedula_usuario = this.txt_cedula.Text;
                this.usu.Nombre_usuario = this.txt_nombre.Text;
                this.usu.Apellido1 = this.txt_apellido1.Text;
                this.usu.Apellido2 = this.txt_apellido2.Text;
                this.usu.Nick_name = this.txt_nickname.Text;
                this.usu.Correo_electronico = this.txt_correo.Text;
                this.usu.Clave_usuario = this.txt_clave2.Text;
                this.usu.Rol = "administrador";
                this.usu.Estado = "Activo";
                this.usu.Opc = 1;
                this.usuariosHelper = new UsuariosHelper(usu);
                this.usuariosHelper.Agregar_Usuarios();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);

            }
            else
            {
                this.txt_clave2.Text = "las contraseñas no coinciden por favor verifique";


            }
            
        }
    }
}