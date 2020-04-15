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
    public partial class Consulta_Caja_chica : System.Web.UI.Page
    {
        private static int GloID;    
        private Caja_Chica caja;
        private Caja_Chica_Helper cajaHelper;
        private DataTable datos;
        private float saldo;          
        private float saldo_final;
        private float movimiento_dinero;
 

        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Contents.RemoveAll();
        }

        protected void Gridcaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                Session["Id_Caja"] = int.Parse(this.Gridcaja.SelectedRow.Cells[2].Text); 
                Response.Redirect("Consulta_movi_caja.aspx");               

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
        protected void Gridcaja_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "movi")
                {
                    int index = int.Parse(e.CommandArgument.ToString());
                    GloID = int.Parse(Gridcaja.DataKeys[index].Value.ToString());
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

        protected void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                int tipomovi;
                this.caja = new Caja_Chica();
                this.caja.Opc = 3;
                this.caja.Concepto_movimiento = this.txt_detalle.Text;
                this.caja.Fecha_inicio = fecha.Value;
                if (this.Dptmovi.SelectedValue == "Ingreso")
                {

                    this.caja.Tipo_movimiento = "Ingreso";
                    tipomovi = 1;
                }
                else {
                    this.caja.Tipo_movimiento = "Egreso";
                     tipomovi = 0;
                }


                this.caja.Movimiento_dinero = float.Parse(this.txtMontito.Text) ;            
                movimiento_dinero = float.Parse(this.txtMontito.Text);
                saldo = float.Parse(this.LblSaldo.Text);
                if (tipomovi == 1)
                {
                    saldo_final = saldo + movimiento_dinero;
                }
                else
                {
                    saldo_final = saldo - movimiento_dinero;
                }
                this.caja.Saldo1 = saldo_final;               
                this.caja.Id_Caja = int.Parse(this.LblId_Caja.Text);
                this.cajaHelper = new Caja_Chica_Helper(caja);
                this.cajaHelper.Agregar_Movimiento();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        public void buscaSaldos()
        {
            try
            {
                this.caja = new Caja_Chica();
                this.caja.Opc = 6;
                this.caja.Id_Caja = int.Parse(this.LblId_Caja.Text);
                this.cajaHelper = new Caja_Chica_Helper(caja);
                this.datos = new DataTable();

                this.datos = this.cajaHelper.Consulta_saldo();
                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    saldo = float.Parse(fila["Saldo"].ToString());
                   
                }


            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Caja_chica.aspx");
        }
    }
}
