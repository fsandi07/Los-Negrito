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
    public partial class Ver_Usuarios : System.Web.UI.Page
    {

        private Usuarios usuarios;
        private DataTable datos;
        private UsuariosHelper usuarioshelper;
        private static string Nombre;
        private static string Apellido;
        private static string Clave;


        protected void Page_Load(object sender, EventArgs e)
        {
            //listarUsuarios();
        }

        private void listarUsuarios()
        {

            try
            {
                this.usuarios = new Usuarios();
                this.usuarios.Opc = 1;
                this.usuarioshelper = new UsuariosHelper(usuarios);
                this.datos = new DataTable();
                this.datos = this.usuarioshelper.Listar_Usuarios();

                if (datos.Rows.Count >= 0)
                {

                    DataRow fila = datos.Rows[0];
                    this.usuarios.Nombre_usuario= fila["nombre_usuario"].ToString();
                    this.usuarios.Apellido1= fila["apellido1"].ToString();
                    this.usuarios.Clave_usuario= fila["clave_usuario"].ToString();                   
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        protected void Btn_redirije_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agregar_usuarios.aspx");
        }

        protected void Grid_usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalUsuarios", "$('#ModalUsuarios').modal();", true);
            this.txt_cedula.Text =this.Grid_usuarios.Rows[Grid_usuarios.SelectedIndex].Cells[1].Text;
            this.txt_nombre.Text = this.Grid_usuarios.Rows[Grid_usuarios.SelectedIndex].Cells[2].Text;
            this.txt_apellido1.Text = this.Grid_usuarios.Rows[Grid_usuarios.SelectedIndex].Cells[3].Text;
            this.txt_apellido2.Text = this.Grid_usuarios.Rows[Grid_usuarios.SelectedIndex].Cells[4].Text;
            this.txt_nickname.Text = this.Grid_usuarios.Rows[Grid_usuarios.SelectedIndex].Cells[5].Text;
            this.txt_correo.Text = this.Grid_usuarios.Rows[Grid_usuarios.SelectedIndex].Cells[6].Text;
        }

        protected void btn_modificar_usuarios_Click(object sender, EventArgs e)
        {
            try
            {

                this.usuarios = new Usuarios();
                this.usuarios.Cedula_usuario = this.txt_cedula.Text;
                this.usuarios.Nombre_usuario = this.txt_nombre.Text;
                this.usuarios.Apellido1 = this.txt_apellido1.Text;
                this.usuarios.Apellido2 = this.txt_apellido2.Text;
                this.usuarios.Nick_name = this.txt_nickname.Text;
                this.usuarios.Correo_electronico = this.txt_correo.Text;
                this.usuarios.Rol = "Administrador";
                this.usuarios.Estado = dptestado.SelectedValue;
                this.usuarios.Opc = 3;
                this.usuarioshelper = new UsuariosHelper(usuarios);
                this.usuarioshelper.Modificar_usuarios();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
    }
}