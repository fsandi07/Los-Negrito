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
            Session.Contents.RemoveAll();
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
            Session["id_colaborador"] = grid_pagos_empleados.SelectedRow.Cells[7].Text;
            Session["salario_quincenal"] = grid_pagos_empleados.SelectedRow.Cells[8].Text;
            Session["comision"] = grid_pagos_empleados.SelectedRow.Cells[9].Text;
            Session["prestamos"] = grid_pagos_empleados.SelectedRow.Cells[10].Text;
            Session["dias_sin_goce"] = grid_pagos_empleados.SelectedRow.Cells[11].Text;
            //
            Session["total_dias_sin_goce"] = grid_pagos_empleados.SelectedRow.Cells[12].Text;
            //
            Session["dias_feriados"] = grid_pagos_empleados.SelectedRow.Cells[13].Text;
            Session["total_feriados"] = grid_pagos_empleados.SelectedRow.Cells[14].Text;
            Session["horas_extras"] = grid_pagos_empleados.SelectedRow.Cells[15].Text;
            Session["total_horas_extras"] = grid_pagos_empleados.SelectedRow.Cells[16].Text;
            Session["salario_neto"] = grid_pagos_empleados.SelectedRow.Cells[17].Text;
            Session["porcentaje_caja"] = grid_pagos_empleados.SelectedRow.Cells[18].Text;
            Session["impuesto_renta"] = grid_pagos_empleados.SelectedRow.Cells[19].Text;
            Session["otras_deducciones"] = grid_pagos_empleados.SelectedRow.Cells[20].Text;
            Session["detalle_otras_deducciones"] = grid_pagos_empleados.SelectedRow.Cells[21].Text;
            Session["total_deducciones"] = grid_pagos_empleados.SelectedRow.Cells[22].Text;
            Session["saldo_anterior"] = grid_pagos_empleados.SelectedRow.Cells[23].Text;
            Session["saldo"] = grid_pagos_empleados.SelectedRow.Cells[24].Text;
            Session["total_depositado"] = grid_pagos_empleados.SelectedRow.Cells[25].Text;
            Session["total_caja"] = grid_pagos_empleados.SelectedRow.Cells[29].Text;
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Actualizar", "Actualizar('" + "" + "');", true);
        }
    }
}