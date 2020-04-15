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
        private Partida Partidas;
        private Partida_Helper PartidasHelper;
        private Control_gasto Control;
        private Control_gasto_Helper ControlHelper;
        private string id_partida;
        private DataTable datos;
        private int periodo;
        private float monto_total;
        private string id_centroCostos;

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

                if (this.Radioaprobada1.Checked)
                {
                    this.EgresoM.Gti = "Si";
                }
                else if (this.Radioaprobada2.Checked)
                {
                    this.EgresoM.Gti = "No";
                }
                this.EgresoM.Nombre_comercio = this.txt_Nombre_comercio_egreso.Text;
                if (this.TxtCedula_juridica.Text == null)
                {
                    this.EgresoM.Cedula_juridica = "No existe";
                }
                else {
                    this.EgresoM.Cedula_juridica = this.TxtCedula_juridica.Text;
                }
                this.EgresoM.Id_detalle = this.DptClasificacion.SelectedValue;
                this.EgresoM.Id_partida = this.DptPartida.SelectedValue;               
                this.EgresoM.Monto_factura = this.TxtMontoTotal.Text;              
                if (this.Radiopagada_si.Checked)
                {
                    this.EgresoM.Estado_pago = "Si";
                    this.EgresoM.Plazo_pago = "0";
                    this.Dpt_plazo_pago.Enabled = true;
                    this.EgresoM.Id_banco = this.DptBanco.SelectedValue;
                    this.EgresoM.Id_metodo_pago = this.DptMetodoPago.SelectedValue;

                }
                else if (this.Radiopagada_no.Checked)
                {
                    this.EgresoM.Estado_pago = "No";
                    this.EgresoM.Plazo_pago = this.Dpt_plazo_pago.SelectedValue;
                    this.EgresoM.Id_banco = "Pendiente";
                    this.EgresoM.Id_metodo_pago = "Pendiente";
                    this.DptBanco.Enabled = true;
                    this.DptMetodoPago.Enabled = true;
                }
                validarpago();
                if (/*this.Dptexiste.SelectedValue == "Si"*/ this.file_pdf.FileName!="")
                {
                    this.EgresoM.Pdf_factura = this.file_pdf.FileBytes;
                    this.EgresoM.Nombre_pdf = this.file_pdf.FileName;
                    this.EgresoM.Fisica = "Sí";
                }
                else if (/*this.Dptexiste.SelectedValue == "No" */ this.file_pdf.FileName == "")
                {
                    this.EgresoM.Pdf_factura = null;
                    this.EgresoM.Nombre_pdf = "No existe documento";
                    this.EgresoM.Fisica = "No";
                }

                this.EgresoM.Id_centroCostos = this.DptCCostos_EXML.SelectedValue;
                this.EgresoM.Moneda = this.DptMoneda.SelectedValue;
                if (this.DptMoneda.SelectedValue == "USD")
                {
                    this.EgresoM.Tipo_cambio = this.TxtTipocambio.Text;
                    
                }
                else {
                    this.EgresoM.Tipo_cambio = "0";
                }
                //this.EgresoM.PorcenIva = PorcentajeIVA.Value;
                this.EgresoM.Mes = fecha.Value;
                this.EgresoM.TotalIva = this.TxtTotalIva.Text;
                this.EgresoM.Estado = "Activo";


                monto_total = float.Parse(TxtMontoTotal.Text);
                id_partida = this.DptPartida.SelectedValue;
                id_centroCostos = this.DptCCostos_EXML.SelectedValue;
                buscaperiodo();
                Ingresar_movi_consulta();
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
        public void validarpago()
        {
            if (this.Radiopagada_si.Checked) {
                if (this.DptBanco.SelectedValue == "" || this.DptMetodoPago.SelectedValue == "") {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajevalidacion1()", "mensajevalidacion1()('" + "" + "');", true);
                }
                else { }

            }
            else if (this.Radiopagada_no.Checked) {
                if (this.Dpt_plazo_pago.SelectedValue == "0")
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajevalidacion3()", "mensajevalidacion3()('" + "" + "');", true);
                }
                else { }
            }
        }
        public void IngresaControl()
        {
            if (this.Radiopagada_si.Checked)
            {
                if (this.DptBanco.SelectedValue == "" || this.DptMetodoPago.SelectedValue == "")
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajevalidacion1()", "mensajevalidacion1()('" + "" + "');", true);
                }
                else { }

            }
            else if (this.Radiopagada_no.Checked)
            {
                if (this.Dpt_plazo_pago.SelectedValue == "0")
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajevalidacion3()", "mensajevalidacion3()('" + "" + "');", true);
                }
                else { }
            }
        }

        public void buscaperiodo()
        {
            try
            {
                this.Partidas = new Partida();
                this.Partidas.Opc = 4;
                this.Partidas.Numero_partida = id_partida;

                this.PartidasHelper = new Partida_Helper(Partidas);               
                this.datos = new DataTable();
                this.datos = this.PartidasHelper.Consulta_Partidas();              
                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    periodo = int.Parse(fila["periodo"].ToString());
                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        public void Ingresar_movi_consulta()
        {
            try
            {
                this.Control = new Control_gasto();
                this.Control.Opc = 1;
                this.Control.Id_partidas = id_partida;
                this.Control.Id_centro_costos = id_centroCostos;
                this.Control.Periodo = periodo;
                this.Control.Total = monto_total;

                this.ControlHelper = new Control_gasto_Helper(Control);
                this.ControlHelper.Agregar_Control();        
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }

        }

    }
}