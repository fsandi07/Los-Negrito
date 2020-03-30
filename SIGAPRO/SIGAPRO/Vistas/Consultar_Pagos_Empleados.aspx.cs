using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGAPRO.Vistas
{
    public partial class Consultar_Pagos_Empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Btnredirije_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro_pagos.aspx");
            
        }

        protected void grid_pagos_empleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["mes"] = grid_pagos_empleados.SelectedRow.Cells[2].Text;
            Session["periodo"]= grid_pagos_empleados.SelectedRow.Cells[3].Text;
            Session["quincena"] = grid_pagos_empleados.SelectedRow.Cells[4].Text;
            Session["moneda"] = grid_pagos_empleados.SelectedRow.Cells[5].Text;
            Session["fecha_registro"] = grid_pagos_empleados.SelectedRow.Cells[6].Text;
            Session["salario_quincenal"] = grid_pagos_empleados.SelectedRow.Cells[8].Text;
            Session["comision"] = grid_pagos_empleados.SelectedRow.Cells[9].Text;
            Session["prestamos"] = grid_pagos_empleados.SelectedRow.Cells[10].Text;
            Session["dias_sin_goce"] = grid_pagos_empleados.SelectedRow.Cells[11].Text;
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Actualizar", "Actualizar('" + "" + "');", true);
        }
    }
}