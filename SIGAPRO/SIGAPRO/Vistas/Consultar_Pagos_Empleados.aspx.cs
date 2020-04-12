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
using SIGAPRO.NEGOCIO;
using System.Data;

namespace SIGAPRO.Vistas
{
    public partial class Consultar_Pagos_Empleados : System.Web.UI.Page
    {
        private static Byte[] bytes;
        private static int GloID;
        private Pago_Empleados pagoemple;
        private Pago_Empleados_Helper pagoempleHelper;
        private DataTable datos;
        private Banco bancos;
        private bancoHelper bancoshelper;
        private int numcompro;
        private string muestranumcompro;
        private string idBanco;        
        private string nombre_banco;
        private string fecha_registro;
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
            Session["periodo"] = grid_pagos_empleados.SelectedRow.Cells[3].Text;
            Session["quincena"] = grid_pagos_empleados.SelectedRow.Cells[5].Text;
            Session["moneda"] = this.LblMoneda.Text;
            Session["fecha_registro"] = fecha_registro;
            Session["id_colaborador"] = this.LblID_colabo.Text ;
            Session["salario_quincenal"] = this.LblQuincenal.Text;
            Session["comision"] = this.LblComision.Text;
            Session["prestamos"] = this.LblPretsamo.Text;
            Session["dias_sin_goce"] = this.Lbldias_sin_goce.Text;
            //
            Session["total_dias_sin_goce"] = this.Lbl_total_sin_goce.Text;
            //
            Session["dias_feriados"] = this.LblDiasFeriados.Text;
            Session["total_feriados"] = this.LblTotal_feriado.Text;
            Session["horas_extras"] = this.LblHoras_extras.Text;
            Session["total_horas_extras"] = this.LblTotal_extras.Text;
            Session["salario_neto"] = this.LblSalario_neto.Text;
            Session["porcentaje_caja"] = this.LblCCSS.Text;
            Session["impuesto_renta"] = this.LblISR.Text;
            Session["otras_deducciones"] = this.LblOtras_deduc.Text;
            Session["detalle_otras_deducciones"] = this.LblConcepto.Text;
            Session["total_deducciones"] = this.LblTotal_Deduc.Text;
            Session["saldo_anterior"] = this.LblSaldo_anterior.Text;
            Session["saldo"] = this.LblSaldo.Text;
            Session["total_depositado"] = this.LblTotal_depositado.Text;
            Session["total_caja"] = this.LblTotal_ccss.Text;
            ScriptManager.RegisterStartupScript(this, typeof(Page), "Actualizar", "Actualizar('" + "" + "');", true);
        }

        protected void grid_pagos_empleados_SelectedIndexChanged1(object sender, EventArgs e)
        {
           
            try
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ModalDocumentos", "$('#ModalDocumentos').modal();", true);
                
                numcompro = int.Parse(grid_pagos_empleados.SelectedRow.Cells[1].Text);
                if (numcompro < 100) { muestranumcompro = "00" + numcompro; }
                else { muestranumcompro = numcompro.ToString(); }
                this.LblComprobante.Text = muestranumcompro;
                this.Lblnombre.Text = grid_pagos_empleados.SelectedRow.Cells[2].Text; ;
                this.LblQuincena.Text = grid_pagos_empleados.SelectedRow.Cells[5].Text +" Quincena "+"de " +grid_pagos_empleados.SelectedRow.Cells[3].Text +" "+"del " + grid_pagos_empleados.SelectedRow.Cells[4].Text; 
                


                this.pagoemple = new Pago_Empleados();
                this.pagoemple.Opc = 3;
                this.pagoemple.Id_comprobante = int.Parse(grid_pagos_empleados.SelectedRow.Cells[1].Text);

                this.pagoempleHelper = new Pago_Empleados_Helper(pagoemple);
                this.datos = new DataTable();
                this.datos = this.pagoempleHelper.Consulta_num_pago();
                
                if (datos.Rows.Count >= 0)
                {

                    DataRow fila = datos.Rows[0];
                    idBanco = fila["Id_banco"].ToString();
                    buscaBanco();
                    this.LblBanco.Text = "    "+nombre_banco;
                    this.LblMoneda.Text = fila["Moneda"].ToString();
                    this.LblQuincenal.Text= fila["Salario_quincenal"].ToString();
                    this.Lbldias_sin_goce.Text = fila["Dias_sinGoce"].ToString();
                    this.Lbl_total_sin_goce.Text= fila["Total_sinGoce"].ToString();
                    this.LblComision.Text = fila["Comision"].ToString();
                    this.LblPretsamo.Text = fila["Prestamos"].ToString();
                    this.LblDiasFeriados.Text = fila["Dias_feriados"].ToString();
                    this.LblTotal_feriado.Text = fila["Total_feriados"].ToString();
                    this.LblHoras_extras.Text = fila["Horas_extras"].ToString();
                    this.LblTotal_extras.Text = fila["Total_extras"].ToString();
                    this.LblSalario_neto.Text = fila["Salario_neto"].ToString();
                    this.LblCCSS.Text= fila["Porcen_caja"].ToString();
                    this.LblTotal_ccss.Text = fila["Total_caja"].ToString();
                    this.LblISR.Text = fila["Impuesto_renta"].ToString();
                    this.LblOtras_deduc.Text = fila["Otras_deducc"].ToString();
                    this.LblConcepto.Text = fila["Detalle_otras_deduc"].ToString();
                    this.LblTotal_Deduc.Text = fila["Total_deduc"].ToString();
                    this.LblTotal_depositado.Text = fila["Total_depositado"].ToString();
                    this.LblSaldo_anterior.Text = fila["Saldo_anterior"].ToString(); ;
                    this.LblSaldo.Text = fila["Saldo"].ToString();
                    fecha_registro = fila["Fecha_registro"].ToString();
                    this.LblID_colabo.Text = fila["Id_colaborador"].ToString();


                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }



        
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


        public void buscaBanco()
        {
            try
            {
                this.bancos = new Banco();
                this.bancos.Opc = 3;
                this.bancos.Id_banco = int.Parse(idBanco);
                this.bancoshelper = new bancoHelper(bancos);
                this.datos = new DataTable();
                this.datos = this.bancoshelper.Consulta_Bancos();
                if (datos.Rows.Count >= 0)
                {
                    DataRow fila = datos.Rows[0];
                    nombre_banco = fila["nombre_banco"].ToString();
                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

    }
    
}