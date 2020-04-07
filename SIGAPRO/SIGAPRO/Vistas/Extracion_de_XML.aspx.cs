using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using SIGAPRO.NEGOCIO;
using System.Data;

namespace SIGAPRO.Vistas
{
    public partial class Extracion_de_XML : System.Web.UI.Page
    {
        private DatosXML datos_Del_XML;
        private DataTable datos;
        private XMLHELPER XMLHELPER;
        private Egreso_manual EgresoM;
        private Egreso_Manual_Helper EgrsoHelper;
        protected void Page_Load(object sender, EventArgs e)
        {
                      listarXML();


            if (txt_plazo_credito.Text == "0") {
                this.DptBanco.Enabled = true;
                this.DptMetodoPago.Enabled = true;
            
            }
        }
     

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consulta_Pagos.aspx");
        }

        private void listarXML()
            {

            try
            {
                this.datos_Del_XML = new DatosXML();
                this.datos_Del_XML.Opc = 1;
                this.XMLHELPER = new XMLHELPER(datos_Del_XML);
                this.datos = new DataTable();
                this.datos = this.XMLHELPER.mostrarxml();

                if (datos.Rows.Count >= 0)
                {

                    DataRow fila = datos.Rows[0];
                    this.txt_fecha_emision.Text = fila["fecha_de_emison"].ToString();
                    this.txt_numero_factura.Text = fila["numero_factura"].ToString();
                    this.txt_nombre_comercio.Text = fila["nombre_comercio"].ToString();
                    this.txt_cedula_juridica.Text = fila["cedula_juridica"].ToString();
                    this.TxtMoneda.Text = fila["Moneda"].ToString();
                    if (fila["Tipo_cambio"].ToString() == "")
                    {

                        this.TxtCambio.Text = "0";
                    }
                    else { 
                    
                        this.TxtCambio.Text = fila["Tipo_cambio"].ToString();
                    }
                    if (fila["Plazo_credito"].ToString() == "")
                    {
                        this.txt_plazo_credito.Text = 0.ToString();

                    }
                    else
                    {

                        this.txt_plazo_credito.Text = fila["Plazo_credito"].ToString();

                    }
                    this.txt_total_iva.Text = fila["total_IVA"].ToString();
                    this.txt_total_pagar.Text = fila["total_pagar"].ToString();
                }
               BorrarXML();
            }
            catch (Exception )
            {
                //throw new Exception(ex.Message);

            }

        }

        private void BorrarXML()
        {

            try
            {
                this.datos_Del_XML = new DatosXML();
                this.datos_Del_XML.Opc = 2;
                this.datos_Del_XML.NumFactura = this.txt_numero_factura.Text;
                this.XMLHELPER = new XMLHELPER(datos_Del_XML);
                this.XMLHELPER.borrarxml();
            }
            catch (Exception ex)
            {
               

            }

        }
        private void limpiar()
        {

            this.TxtCambio.Text = null;
            this.TxtMoneda.Text = null;
            this.txt_cedula_juridica.Text = null;
            this.txt_fecha_emision.Text = null;
            this.txt_nombre_comercio.Text = null;
            this.txt_numero_factura.Text = null;
            this.txt_plazo_credito.Text = null;
            this.txt_total_iva.Text = null;
            this.txt_total_pagar.Text = null;
            this.DptBanco.SelectedValue = null;
            this.DptCCostos_EXML.SelectedValue = null;
            this.DptClasificacion.SelectedValue = null;
            this.DptMetodoPago.SelectedValue = null;
            this.DptPartida.SelectedValue = null;

        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.EgresoM = new Egreso_manual();
                this.EgresoM.Opc = 1;
                this.EgresoM.Digital = "Si";
                this.EgresoM.Fecha_registro = this.txt_fecha_emision.Text;
                this.EgresoM.Numero_factura = this.txt_numero_factura.Text;

                if (this.Radioaprobada1.Checked)
                {
                    this.EgresoM.Gti = "Si";
                }
                else if (this.Radioaprobada2.Checked)
                {
                    this.EgresoM.Gti = "No";
                }
                this.EgresoM.Nombre_comercio = this.txt_nombre_comercio.Text;
                if (this.txt_cedula_juridica.Text == null)
                {
                    this.EgresoM.Cedula_juridica = "No existe";
                }
                else
                {
                    this.EgresoM.Cedula_juridica = this.txt_cedula_juridica.Text;
                }
                this.EgresoM.Id_detalle = this.DptClasificacion.SelectedValue;
                this.EgresoM.Id_partida = this.DptPartida.SelectedValue;
                this.EgresoM.Monto_factura = this.txt_total_pagar.Text;

                if (this.txt_plazo_credito.Text == "0") {

                    this.EgresoM.Estado_pago = "Si";
                    this.EgresoM.Id_banco = this.DptBanco.SelectedValue;
                    this.EgresoM.Id_metodo_pago = this.DptMetodoPago.SelectedValue;
                    this.EgresoM.Plazo_pago = this.txt_plazo_credito.Text;

                }
                else if (this.txt_plazo_credito.Text != "0") {
                    this.EgresoM.Estado_pago = "Si";
                    this.EgresoM.Id_banco = "Pendiente";
                    this.EgresoM.Id_metodo_pago = "Pendiente";
                    this.EgresoM.Plazo_pago = this.txt_plazo_credito.Text;

                }
              
                if ( this.file_pdf.FileName != "")
                {
                    this.EgresoM.Pdf_factura = this.file_pdf.FileBytes;
                    this.EgresoM.Nombre_pdf = this.file_pdf.FileName;
                    this.EgresoM.Fisica = "Sí";
                }
                else if (this.file_pdf.FileName == "")
                {
                    this.EgresoM.Pdf_factura = null;
                    this.EgresoM.Nombre_pdf = "No existe documento";
                    this.EgresoM.Fisica = "No";
                }

                this.EgresoM.Id_centroCostos = this.DptCCostos_EXML.SelectedValue;
                this.EgresoM.Moneda = this.TxtMoneda.Text;
                if (this.TxtMoneda.Text == "USD")
                {
                    this.EgresoM.Tipo_cambio = this.TxtCambio.Text;
                }
                else
                {
                    this.EgresoM.Tipo_cambio = "0";
                }
                //this.EgresoM.PorcenIva = PorcentajeIVA.Value;
                this.EgresoM.Mes = this.txt_fecha_emision.Text;
                this.EgresoM.TotalIva = this.txt_total_iva.Text;
                this.EgresoM.Estado = "Activo";

                this.EgrsoHelper = new Egreso_Manual_Helper(EgresoM);
                this.EgrsoHelper.Agrergar_Egreso_manual();

                limpiar();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

    }
}