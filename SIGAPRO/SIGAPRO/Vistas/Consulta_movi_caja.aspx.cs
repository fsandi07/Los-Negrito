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
    public partial class Consulta_movi_caja : System.Web.UI.Page
    {
        private int id_caja_grid;
        private Caja_Chica caja;
        private Caja_Chica_Helper cajaHelper;
        private DataTable datos;
        private float saldo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id_caja_grid = (int)Session["Id_Caja"];
                SqlDataMovimiento.SelectCommand = "SELECT * FROM tb_Caja_Movi_los_negritos where Id_Caja = '" + id_caja_grid + "'";
                SqlDataMovimiento.DataBind();
                buscaSaldos();
                this.LblSaldo.Text = saldo.ToString();

            }
            else
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consulta_Caja_chica.aspx");
        }

        protected void GridMovimientos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string estado;
                estado = (string)DataBinder.Eval(e.Row.DataItem, "Tipo_movi");
                if (estado == "Egreso")
                {
                    //e.Row.BackColor = System.Drawing.Color.Red;
                    //e.Row.Font.Bold = true;
                    e.Row.ForeColor = System.Drawing.Color.Red;  
                }

            }
        }

        public void buscaSaldos()
        {
            try
            {
                this.caja = new Caja_Chica();
                this.caja.Opc = 6;
                this.caja.Id_Caja = id_caja_grid;
                this.cajaHelper = new Caja_Chica_Helper(caja);
                this.datos = new DataTable();

                this.datos = this.cajaHelper.Consulta_saldo();
                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    saldo = float.Parse(fila["Saldo"].ToString());
                    
                }


            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }


    }
}