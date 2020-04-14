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
    public partial class Caja_chica : System.Web.UI.Page
    {
        private Caja_Chica caja;
        private Caja_Chica_Helper cajaHelper;
        private DataTable datos;
        private int numcaja;
        private int num;


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Btn_redirije_Click(object sender, EventArgs e)
        {
            try
            {
                this.caja = new Caja_Chica();
                this.caja.Opc = 1;
                this.caja.Nombre_Caja = this.txt_nombre_caja.Text;
                this.caja.Descripcion1 = this.txt_descripcion.Text;
                this.caja.Fecha_inicio = fecha.Value;
                this.caja.Saldo_inicial = float.Parse(this.TxtSaldo_inicial.Text);
                this.caja.Estado = "Activo";

                this.cajaHelper = new Caja_Chica_Helper(caja);
                this.cajaHelper.Agregar_Caja();
                Primer_movimiento();
                this.txt_nombre_caja.Text = null;
                this.txt_descripcion.Text = null;
                this.TxtSaldo_inicial.Text = null;              
                               

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        public void Primer_movimiento()
        {
            try
            {
                buscaIdCaja();
                this.caja = new Caja_Chica();
                this.caja.Opc = 3;
                this.caja.Concepto_movimiento = "Ingreso Inicial";
                this.caja.Fecha_movimiento = fecha.Value;
                this.caja.Movimiento_dinero = float.Parse(this.TxtSaldo_inicial.Text);
                this.caja.Saldo1 = float.Parse(this.TxtSaldo_inicial.Text);
                this.caja.Tipo_movimiento = "Ingreso";               
                this.caja.Id_Caja = numcaja;
                this.cajaHelper = new Caja_Chica_Helper(caja);
                this.cajaHelper.Agregar_Movimiento();

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
        public void buscaIdCaja()
        {
            
            try
            {
                this.caja = new Caja_Chica();
                this.caja.Opc = 5;
                this.cajaHelper = new Caja_Chica_Helper(caja);
                this.datos = new DataTable();

                this.datos = this.cajaHelper.Consulta_Cajas();
                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    numcaja = int.Parse(fila["Id_Caja"].ToString());
                }
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
    }
}