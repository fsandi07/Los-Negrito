using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGAPRO.Vistas
{
    public partial class Egreso_Manual : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consulta_Pagos.aspx");
        }


    }
}