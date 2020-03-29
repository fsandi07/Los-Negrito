using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGAPRO.Vistas
{
    public partial class Registro_ingreso_pollinaza : System.Web.UI.Page
    {
        public static int cantidad;
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consultar_Ingresos.aspx");
            cantidad = int.Parse(CantidadSacos.Value);
        }

       

        
    }
}