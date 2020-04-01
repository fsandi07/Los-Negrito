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
    public partial class Egreso_Manual : System.Web.UI.Page
    {
      
        private Egreso_manual EgresoM;
        private Egreso_Manual_Helper EgrsoHelper;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consulta_Pagos.aspx");
        }

        protected void txt_num_factura_TextChanged(object sender, EventArgs e)
        {
            this.txt_Nombre_comercio_egreso.Text = "Esto es una prueba";
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.EgresoM = new Egreso_manual();
                this.EgresoM.Opc = 1;
                this.EgresoM.Digital = "No";
                this.EgresoM.Fecha_registro = fecha.Value;
                this.EgresoM.Numero_factura = this.txt_num_factura.Text;
                
                if (this.Radioaprobada1.Checked) {
                    this.EgresoM.Gti = "Si";
                }
                else if  (this.Radioaprobada2.Checked) {
                    this.EgresoM.Gti = "No";
                }
                this.EgresoM.Nombre_comercio = this.txt_Nombre_comercio_egreso.Text;
                this.EgresoM.Id_detalle = this.DptClasificacion.SelectedValue;
                this.EgresoM.Id_partida = this.DptPartida.SelectedValue;
                this.EgresoM.Monto_factura = MontoFactura.Value;
                if (this.Radiopagada_si.Checked) {
                    this.EgresoM.Estado_pago = "Si";
                    this.EgresoM.Plazo_pago = "0";
                    this.Dpt_plazo_pago.Enabled = true;
                    this.EgresoM.Id_banco = this.DptBanco.SelectedValue;
                    this.EgresoM.Id_metodo_pago = this.DptMetodoPago.SelectedValue;

                }
                else if (this.Radiopagada_no.Checked) {
                    this.EgresoM.Estado_pago = "No";
                    this.EgresoM.Plazo_pago = this.Dpt_plazo_pago.SelectedValue;
                    this.EgresoM.Id_banco = "Pendiente";
                    this.EgresoM.Id_metodo_pago = "Pendiente";
                    this.DptBanco.Enabled = true;
                    this.DptMetodoPago.Enabled = true;
                }

                if (this.Dptexiste.SelectedValue == "Si") {
                    this.EgresoM.Pdf_factura = this.file_pdf.FileBytes;
                    this.EgresoM.Nombre_pdf = this.file_pdf.FileName;
                }
                else if (this.Dptexiste.SelectedValue == "No") {
                    this.EgresoM.Pdf_factura = null;
                    this.EgresoM.Nombre_pdf = "No existe documento";
                }

                this.EgresoM.Id_centroCostos = this.DptCCostos_EXML.SelectedValue;                
                this.EgresoM.Moneda = this.DptMoneda.SelectedValue;
                this.EgresoM.PorcenIva = PorcentajeIVA.Value;
                this.EgresoM.TotalIva = TotalIva.Value;
                this.EgresoM.Estado = "Activo";

                this.EgrsoHelper = new Egreso_Manual_Helper(EgresoM);
                this.EgrsoHelper.Agrergar_Egreso_manual();

               
                this.txt_Nombre_comercio_egreso.Text = null;
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