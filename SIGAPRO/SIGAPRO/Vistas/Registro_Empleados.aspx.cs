using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIGAPRO.NEGOCIO;

namespace SIGAPRO.Vistas
{
    public partial class Registro_Empleados : System.Web.UI.Page
    {
        private Empleados colabo;
        private Empleados_Helper colaboHelper;
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void btn_registra_Click(object sender, EventArgs e)
        {
            try
            {
                this.colabo = new Empleados();
                this.colabo.Opc = 1;
                this.colabo.Nombre_empelado = this.txt_Nombre.Text;
                this.colabo.Cedula_empleado = this.txt_identificacion.Text;
                this.colabo.Apellido1_empleado = this.txt_Apellido1.Text;
                this.colabo.Apellido2_empleado = this.txt_Apellido2.Text;
                this.colabo.Domicilio = this.txt_Domicilio.Text;
                this.colabo.Telefono_empleado = this.txt_Numero_telefonico.Text;
                this.colabo.Correo_empleado = this.txt_Correo_Electronico.Text;
                this.colabo.Cuenta_banco_empleado = this.txt_Cuenta_IBAN.Text;
                this.colabo.Fecha_inicio_empleado = fecha_ingreso.Value;
                this.colabo.Fecha_nacimientoi_empleado = fecha_nacimiento.Value;
                this.colabo.Estado_empleado = "Activo";

                this.colaboHelper = new Empleados_Helper(colabo);
                this.colaboHelper.Agregar_Empleado();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                this.txt_Nombre.Text = null;
                this.txt_identificacion.Text = null;
                this.txt_Apellido1.Text = null;
                this.txt_Domicilio.Text = null;
                this.txt_Numero_telefonico.Text = null;
                this.txt_Correo_Electronico.Text = null;
                this.txt_Cuenta_IBAN.Text = null;
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
           




        }
    }
}