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
    public partial class Registro_ingreso_pollinaza : System.Web.UI.Page
    {
      

        private Ingreso_Pollinaza ingrepolli;
        private Ingresar_Pollinaza_Helper ingrepolliHelper;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_cancelar_Click(object sender, EventArgs e)
        {

            Response.Redirect("Consultar_Ingresos.aspx");


        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ingrepolli = new Ingreso_Pollinaza();
                this.ingrepolli.Opc = 1;
                this.ingrepolli.Id_partida = this.Dpt_partida.SelectedValue;
                if (this.Radiopagada_si.Checked)
                {
                    this.ingrepolli.Estado_pago = "Cancelada";
                    this.ingrepolli.Plazo_pago = "0";
                }
                else if (this.Radiopagada_no.Checked)
                {
                    this.ingrepolli.Estado_pago = "Pendiente";
                    this.ingrepolli.Plazo_pago = this.Dpt_plazo_pago.SelectedValue;
                }

                this.ingrepolli.Numero_factura = this.txt_num_factura.Text;
                this.ingrepolli.Nomnbre_cliente = this.txt_Nombre_cliente.Text;
                this.ingrepolli.Fecha_emision = fecha.Value;
                this.ingrepolli.Cantidad_sacos = CantidadSacos.Value;
                this.ingrepolli.Precio_unidad = MontoPorunidad.Value;
                this.ingrepolli.Total_pago = total.Value;
                this.ingrepolli.Pdf_comprobante = this.file_pdf.FileBytes;
                this.ingrepolli.Nombre_pdf = this.file_pdf.FileName;
                this.ingrepolli.Estado = "Activo";


                this.ingrepolliHelper = new Ingresar_Pollinaza_Helper(ingrepolli);
                this.ingrepolliHelper.Agrergar_Ingreso_Pollinaza();

                this.txt_Nombre_cliente.Text = null;
                this.txt_num_factura.Text = null;

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);


            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }

        }
    }
}