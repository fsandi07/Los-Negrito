using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGAPRO.Vistas
{
    public partial class Consulta_Pagos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }               

        protected void btnExtraccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Extracion_de_XML.aspx");
        }

        protected void btnManual_Click(object sender, EventArgs e)
        {
            Response.Redirect("Egreso_Manual.aspx");
        }
    }
}