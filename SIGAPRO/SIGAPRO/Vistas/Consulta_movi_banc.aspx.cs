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
    public partial class Consulta_movi_banc : System.Web.UI.Page
    {
        private static int GloID;
        private Movimientos_Bancarios movibanck;
        private Movimientos_bancarios_Helper movihelper;
        private DataTable datos;
        private float saldo;
        private float monto;

        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Contents.RemoveAll();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro_movi_banc.aspx");
        }

        protected void Gridmovi_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Session["Id_Movimiento"] = int.Parse(this.Gridmovi.SelectedRow.Cells[2].Text);
                Response.Redirect("Ver_movi_banc.aspx");

            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        protected void Gridmovi_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            try
            {
                if (e.CommandName == "movi")
                {
                    int index = int.Parse(e.CommandArgument.ToString());
                    GloID = int.Parse(Gridmovi.DataKeys[index].Value.ToString());
                    this.LblId_Caja.Text = GloID.ToString();
                    buscaSaldos();
                    this.LblSaldo.Text = saldo.ToString();
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalMovimientos", "$('#ModalMovimientos').modal();", true);
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        public void buscaSaldos()
        {
            try
            {
                this.movibanck = new Movimientos_Bancarios();
                this.movibanck.Opc = 2;
                this.movibanck.Id_registro_banco = GloID;

                this.movihelper = new Movimientos_bancarios_Helper(movibanck);
                this.datos = new DataTable();

                this.datos = this.movihelper.Consulta_saldo();
                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    saldo = float.Parse(fila["saldo"].ToString());

                }


            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (fecha.Value == "")
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeAviso", "mensajeAviso('" + "" + "');", true);

                }
                else { 
                string tipomovi;
                float saldo_total;
                this.movibanck = new Movimientos_Bancarios();
                this.movibanck.Opc = 1;
                this.movibanck.Fecha_movi_regis = fecha.Value;
                this.movibanck.Detalle_registro = this.txt_detalle.Text;
                    this.movibanck.Financia = int.Parse(this.DptFinanciamiento.SelectedValue);
                    if (int.Parse(this.DptFinanciamiento.SelectedValue) == 0)
                    {
                        this.movibanck.Centro_costos = "N/A";
                    }
                    else {
                        this.movibanck.Centro_costos = this.DptCostos.SelectedValue;
                    
                    }

                this.movibanck.Cantidad_dinero = float.Parse(this.txtMontito.Text);
                this.movibanck.Tipo_registro = this.Dptmovi.SelectedValue;
                tipomovi = this.Dptmovi.SelectedValue;
                monto = float.Parse(this.txtMontito.Text);
                saldo = float.Parse(this.LblSaldo.Text);
                if (tipomovi == "Ingreso")
                {
                    saldo_total = saldo + monto;
                    this.movibanck.Saldo = saldo_total;
                }
                else {
                    saldo_total = saldo - monto;
                    this.movibanck.Saldo = saldo_total;

                }
                this.movibanck.Id_registro_banco = GloID;

                if (this.DptItem.SelectedValue == "N/A")
                {
                   
                    this.movibanck.Numero = "NE";
                    this.movibanck.Item = this.DptItem.SelectedValue;
                }
                else {
                    this.movibanck.Numero = this.TxtNumFactura.Text;
                    this.movibanck.Item = this.DptItem.SelectedValue;
                }
                this.movibanck.Numero = this.TxtNumFactura.Text;
                this.movihelper = new Movimientos_bancarios_Helper(movibanck);
                this.movihelper.Agregar_trans_banc();

                this.txtMontito.Text = null;
                this.TxtNumFactura.Text = null;
                this.txt_detalle.Text = null;
                this.DptItem.SelectedValue = null;
                this.Dptmovi.SelectedValue = null;
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                }

            }
            catch (Exception )
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
    }
}