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
    public partial class Registro_Ingresos : System.Web.UI.Page
    {
        private Banco bank;
        private bancoHelper bankHelper;

        private Ingreso_Aves ingresoAves;
        private Ingreso_Aves_Helper ingresoAvesHelper;

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
                this.ingresoAves = new Ingreso_Aves();
                this.ingresoAves.Opc = 1;
                this.ingresoAves.Id_partida = this.Dpt_partida.SelectedValue;
                if (this.Radiopagada_si.Checked)
                {
                    this.ingresoAves.Estado_pago = "Cancelada";
                    this.ingresoAves.Plazo_pago = "0";
                }
                else {
                    this.ingresoAves.Estado_pago = "Pendiente";
                    this.ingresoAves.Plazo_pago = this.Dpt_plazo_pago.SelectedValue;
                }
                this.ingresoAves.Id_partida = this.Dpt_partida.SelectedValue;               
                this.ingresoAves.Numero_factura = this.txt_num_factura.Text;
                this.ingresoAves.Nombre_comercio = this.txt_Nombre_comercio_ingreso.Text;
                this.ingresoAves.Fecha_emision = fecha.Value;
                this.ingresoAves.Monto_factura = montoFacatura.Value;
                this.ingresoAves.Detalle_factura = this.Dptdetalle.SelectedValue;
                this.ingresoAves.Monto_otra_carga = otrasCargas.Value;
                this.ingresoAves.Detalle_otra_carga = this.txt_detalle_carga.Text;
                this.ingresoAves.Porcent_iva = porcenIva.Value;
                this.ingresoAves.Total_iva = totalIva.Value;
                this.ingresoAves.Total_menos_iva = totalmenosIva.Value;
                this.ingresoAves.Total_menos_otros_iva = totalmenosCargas.Value;
                this.ingresoAves.Pdf_comprobante = this.file_pdf.FileBytes;
                this.ingresoAves.Nombre_pdf = this.file_pdf.FileName;
                this.ingresoAves.Estado = "Activo";

                this.ingresoAvesHelper = new Ingreso_Aves_Helper(ingresoAves);
                this.ingresoAvesHelper.Agrergar_Ingreso_aves();


                this.txt_num_factura.Text = null;               
                this.txt_detalle_carga = null;
                this.txt_Nombre_comercio_ingreso = null;
              

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);


            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
    }
}