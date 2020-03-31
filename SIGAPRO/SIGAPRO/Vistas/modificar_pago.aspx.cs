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
    public partial class modificar_pago : System.Web.UI.Page
    {
        private DataTable datos;
        private Empleados emple;
        private Empleados_Helper empleHelper;
        private Pago_Empleados pagoemple;
        private Pago_Empleados_Helper pagoempleHelper;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.DptMes.SelectedValue = (string)Session["mes"];
            this.Dptyear.SelectedValue = (string)Session["periodo"];
            this.Dpquincena.SelectedValue = (string)Session["quincena"];
            this.DptMoneda.SelectedValue = (string)Session["moneda"];
            //fecha.Value=(string)Session["fecha_registro"];
            //SalarioQuincenal.Value.ToString();
            //comisionProductividad.Value =(string)Session["comision"];
            //prestamo.Value = (string)Session["prestamos"];
            //(string)Session["dias_sin_goce"];
            //Session.Contents.Remove("dias_sin_goce");

        }

        protected void DptColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.emple = new Empleados();
                this.emple.Cedula_empleado = this.DptColaborador.SelectedValue;
                this.emple.Opc = 4;

                this.empleHelper = new Empleados_Helper(emple);
                this.datos = new DataTable();
                this.datos = this.empleHelper.validaEmpleado();
                if (datos.Rows.Count >= 0)
                {

                    DataRow fila = datos.Rows[0];
                    this.txt_Nombre.Text = fila["nombre"].ToString();
                    this.txt_Apellido.Text = fila["apellido1"].ToString() + " " + fila["apellido2"].ToString();
                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
    }
}