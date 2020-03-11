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

    }
}