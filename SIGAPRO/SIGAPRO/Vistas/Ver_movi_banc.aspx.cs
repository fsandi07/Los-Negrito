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
    public partial class Ver_movi_banc : System.Web.UI.Page
    {
        private int id_movi;
        private Movimientos_Bancarios movibanck;
        private Movimientos_bancarios_Helper movihelper;
        private DataTable datos;
        private float saldo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id_movi = (int)Session["Id_Movimiento"];
                SqlDatamovibanc.SelectCommand = " select a.Id_registro as [ID],a.fecha as [Fecha],a.detalle as [Detalle],a.cantidad as [Cantidad],a.saldo as [Saldo],a.item as [Item],a.num_factura as [N° Factura]," +
                    "b.nombre_movi as [Nombre Movimiento],a.tipo_movi as [Tipo]" +
                    "from tb_ingreso_regist_mov_banc_los_negritos a,tb_regis_movi_ban_los_negritos b  where a.id_movi_banc = b.id_registro_banco and a.id_movi_banc  = '" + id_movi + "'";
                SqlDatamovibanc.DataBind();
                buscaSaldos();
                this.LblSaldo.Text = saldo.ToString();

            }
            else
            {

            }
        }

        public void buscaSaldos()
        {
            try
            {
                this.movibanck = new Movimientos_Bancarios();
                this.movibanck.Opc = 2;
                this.movibanck.Id_registro_banco = id_movi;

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
    }
}