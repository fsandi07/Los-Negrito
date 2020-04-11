using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
// librerias agregadas 
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace SIGAPRO.Vistas
{
    public partial class Consultar_Pagos_Empleados : System.Web.UI.Page
    {
        private static Byte[] bytes;
        private static int GloID;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Contents.RemoveAll();
            
        }
        
        protected void Btnredirije_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro_pagos.aspx");
           
        }
             

        protected void Btnmodificar_Click(object sender, EventArgs e)
        {
            Session["Id_comprobante"] = grid_pagos_empleados.SelectedRow.Cells[1].Text;
            Session["mes"] = grid_pagos_empleados.SelectedRow.Cells[2].Text;
            Session["periodo"] = grid_pagos_empleados.SelectedRow.Cells[3].Text;
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

        protected void grid_pagos_empleados_SelectedIndexChanged1(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalDocumentos", "$('#ModalDocumentos').modal();", true);
            this.Lblnombre.Text = grid_pagos_empleados.SelectedRow.Cells[7].Text;
            this.LblQuincena.Text = grid_pagos_empleados.SelectedRow.Cells[4].Text;
            this.DiasFeriados.Text = grid_pagos_empleados.SelectedRow.Cells[14].Text;
        }

        protected void grid_pagos_empleados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            try
            {
                if (e.CommandName == "PDF")
                {
                    
                    int index = int.Parse(e.CommandArgument.ToString());
                    GloID = int.Parse(grid_pagos_empleados.DataKeys[index].Value.ToString());                    
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeEspera()", "mensajeEspera('" + "" + "');", true);
                    AbrirPdf();

                }
             
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        private void AbrirPdf()
        {
            try
            {
                // hacer una entidad antes de hacer este using
               
               
                using (SIGAPRO.EntipagoEmple.DB_A4DE45_SIGEDOCEntities db = new SIGAPRO.EntipagoEmple.DB_A4DE45_SIGEDOCEntities())
                {
                    var oDocument = db.tb_pago_emple_los_negritos.Find(GloID);                  
                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "/temp/";
                    string fullFilePath = folder + oDocument.Realname_pdf;
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }
                    File.WriteAllBytes(fullFilePath, oDocument.Pdf_compro);
                    Byte[] bytes = oDocument.Pdf_compro;                    
                   
                    Process.Start(fullFilePath);
                    //Response.Buffer = true;
                    //Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
                    //Response.ContentType = "application/java/pdf";
                    //Response.AddHeader("content-disposition", "filename=" + oDocument.Realname_pdf);
                    //Response.BinaryWrite(bytes);
                    //Response.Flush();
                    //Response.End();
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }

        }

    }
}