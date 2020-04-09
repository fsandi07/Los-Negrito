using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using SIGAPRO.NEGOCIO;
using System.Web.Mvc;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Image = iTextSharp.text.Image;

namespace SIGAPRO.Vistas
{
    public partial class Registro_pagos : System.Web.UI.Page
    {
        private DataTable datos;
        private Empleados emple;
        private Empleados_Helper empleHelper;
        private Pago_Empleados pagoemple;
        private Pago_Empleados_Helper pagoempleHelper;
        private Banco bancos;
        private bancoHelper bancoshelper;
        private string nombredoc;
        private string apellidos;
        private string nombre_banco;
        private int numcomprobante;
        private string muestranumero;
        private string muestrames;
        private string muestrayear;
        private string yearcompleto;
        private string dias;
        private int muestraDiaa;
       
        

        protected void Page_Load(object sender, EventArgs e)
        {
            buscaNumCompro();
            if (numcomprobante < 100) { muestranumero = "00" + numcomprobante; }
            else { muestranumero = numcomprobante.ToString(); }
            this.Lblnumcompro.Text = muestranumero;
        }

        protected void Btn_redirije_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consultar_Pagos_Empleados.aspx");
        }

        protected void DptColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.emple = new Empleados();
                this.emple.Cedula_empleado = this.DptColaborador.SelectedValue;
                this.emple.Opc = 4;

                this.empleHelper = new Empleados_Helper(emple);
                this.datos = new DataTable();
                this.datos = this.empleHelper.validaEmpleado();
                if (datos.Rows.Count >= 0)
                {

                    DataRow fila = datos.Rows[0];                    
                    this.txt_Nombre.Text = fila["nombre"].ToString();
                    this.txt_Apellido.Text = fila["apellido1"].ToString() + " " + fila["apellido2"].ToString();
                }

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }

        }

        public void buscaBanco() {
            try
            {
                this.bancos = new Banco();
                this.bancos.Opc = 3;
                this.bancos.Id_banco = int.Parse(this.DptBancos.SelectedValue);
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
        public void buscaNumCompro()
        {
            try
            {
                this.pagoemple = new Pago_Empleados();
                this.pagoemple.Opc = 5;
                this.pagoempleHelper = new Pago_Empleados_Helper(pagoemple);
                this.datos = new DataTable();
                this.datos = this.pagoempleHelper.Consulta_num_pago();

                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];
                    numcomprobante = int.Parse(fila["Id_comprobante"].ToString()) + 1;
                }

                numcomprobante = 1;
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }

        protected void btn_Pago_Cola_Click(object sender, EventArgs e)
        {
            
            try
            {

                this.pagoemple = new Pago_Empleados();
                this.pagoemple.Id_comprobante = int.Parse(this.Lblnumcompro.Text);
                ValidaMes();
                muestrayear = fecha.Value;
                yearcompleto = muestrayear.Substring(0, 4);
                this.pagoemple.Mes = muestrames;
                this.pagoemple.Anio = yearcompleto;
                dias = fecha.Value;
                muestraDiaa = int.Parse(dias.Substring(8, 2));
                if (muestraDiaa < 15)
                {
                    this.pagoemple.Quincena = 1;

                }
                else {
                    this.pagoemple.Quincena = 2;
                }
                
                this.pagoemple.Moneda = this.DptMoneda.SelectedValue;
                this.pagoemple.Fecha_registro = fecha.Value;
                this.pagoemple.Id_colaborador = this.DptColaborador.SelectedValue;
                this.pagoemple.Salario_quincenal = SalarioQuincenal.Value;
                this.pagoemple.Comision = comisionProductividad.Value;
                this.pagoemple.Prestamo = prestamo.Value;
                this.pagoemple.Dias_sinGoce = diasSinGoce.Value;
                this.pagoemple.Total_sinGoce = totalsingoce.Value;
                this.pagoemple.Dias_feriados = diasFeriados.Value;
                this.pagoemple.Total_feriados = totalFeriados.Value;
                this.pagoemple.Horas_extras = horasExtras.Value;
                this.pagoemple.Total_extras = totalExtras.Value;
                this.pagoemple.Salario_neto = salarioneto.Value;
                this.pagoemple.Porcen_caja = porcentajeCCSS.Value;
                this.pagoemple.Total_caja = totalCCSS.Value;
                this.pagoemple.Impuesto_renta = impuestoRentas.Value;
                this.pagoemple.Otras_deduc = otrasDeduccion.Value;
                this.pagoemple.Detalle_otras_deduc = this.txtDescripDedud.Text;
                this.pagoemple.Total_deduc = totalDeducciones.Value;
                this.pagoemple.Saldo_anterior = saldoAnterior.Value;
                this.pagoemple.Saldo = saldo.Value;
                this.pagoemple.Total_depositado = totalDepositado.Value;
                this.pagoemple.Id_banco = this.DptBancos.SelectedValue;
                this.pagoemple.Estado = "Activo";
                this.pagoemple.Id_centro_costos = this.DptCentroCostos.SelectedValue;
                this.pagoemple.Pdf_comprobante = this.file_pdf.FileBytes;
                if (this.file_pdf.FileName == "")
                {
                    this.pagoemple.Realname_pdf = "Pendiente de subir";
                }
                else {
                    this.pagoemple.Realname_pdf = this.file_pdf.FileName;
                }                
                this.pagoemple.Opc = 1;
                this.pagoempleHelper = new Pago_Empleados_Helper(pagoemple);
                this.pagoempleHelper.Agregar_pago_empleado();

                Limpiar();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                Response.Redirect("Consultar_Pagos_Empleados.aspx");

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
        public void Limpiar()
        {

            this.Lblnumcompro.Text = null;           
            this.DptMoneda.SelectedValue = null;
            this.txt_Nombre.Text = null;
            this.txt_Apellido.Text = null;
            fecha.Value = null;
            this.DptColaborador.SelectedValue = null;
            SalarioQuincenal.Value = null;
            comisionProductividad.Value = null;
            prestamo.Value = null;
            diasSinGoce.Value = null;
            totalsingoce.Value = null;
            diasFeriados.Value = null;
            totalFeriados.Value = null;
            horasExtras.Value = null;
            totalExtras.Value = null;
            salarioneto.Value = null;
            porcentajeCCSS.Value = null;
            totalCCSS.Value = null;
            impuestoRentas.Value = null;
            otrasDeduccion.Value = null;
            this.txtDescripDedud.Text = null;
            totalDeducciones.Value = null;
            saldoAnterior.Value = null;
            saldo.Value = null;
            totalDepositado.Value = null;
            this.DptBancos.SelectedValue = null;
            this.DptCentroCostos.SelectedValue = null;
        }

        public void ValidaMes() {
            string pruebames = fecha.Value;
            string validames = pruebames.Substring(5, 2);
            if (validames == "01"){ muestrames = "Enero";}
            else if (validames == "02") { muestrames = "Febrero";}
            else if (validames == "03"){muestrames = "Marzo";}
            else if (validames == "04"){muestrames = "Abril";}
            else if (validames == "05"){muestrames = "Mayo";}
            else if (validames == "06"){muestrames = "Junio";}
            else if (validames == "07"){muestrames = "Julio";}
            else if (validames == "08"){muestrames = "Agosto";}
            else if (validames == "09"){muestrames = "Septiembre";}
            else if (validames == "10"){muestrames = "Octubre";}
            else if (validames == "11"){muestrames = "Novimebre";}
            else if (validames == "12"){muestrames = "Diciembre";}

        }


        public ActionResult pdf()
        {
            string centro = "                                                                                       ";
            string centro1 = "                                                                           ";
            string centro2 = "                                                        ";
            nombredoc = this.txt_Nombre.Text;
            apellidos = this.txt_Apellido.Text;
            string calendar = fecha.Value;            
            int muestraDias = int.Parse(calendar.Substring(8, 2));
            string numquincena;
            if (muestraDias < 15) {numquincena = "1";}
            else { numquincena = "2"; }
            string quincenas = numquincena;
            buscaBanco();
            string bancos = nombre_banco;
            string monedapagada = this.DptMoneda.SelectedValue;
            string terminoquincena = "";
            if (quincenas == "1"){terminoquincena = "era";}
            else { terminoquincena = "da";}
            string salarioquince = SalaQuinCompro.Value;
            string diassingoce = diasSinGoce.Value;
            string totalsingoce =  TotalsinGoceCMP.Value;           
            ValidaMes();
            string mes = muestrames;
            string anio = calendar.Substring(0,4);
            string comisionp = ComisionCMP.Value;
            string prestamos = PrestamoCMP.Value;
            string diasferi = diasFeriados.Value;
            string totadericompro = TotalferiadoCMP.Value;            
            string horasEx = horasExtras.Value;
            string totaExtra = TotalExtrasCMP.Value;
            string netocompro = NetoCompro.Value;            
            string porcencaja = porcentajeCCSS.Value;
            string totacajacompro = TotalCajaCMP.Value;           
            string impuestorenta = TotalISRCMP.Value;
            string otradeduc = OtrasDeducCMP.Value;
            string detallededuc = this.txtDescripDedud.Text;
            string totaldeduc = TotalDeducCMP.Value;
            string totaldepo = TotalDepoCMP.Value;
            string saldoante = SaldoAnteCMP.Value;
            string saldocompro = SaldoCMP.Value; 


            //FileStream fs = new FileStream("c://pdf/reporte.pdf", FileMode.Create);
            MemoryStream ms = new MemoryStream();
            Document document = new Document(iTextSharp.text.PageSize.LETTER,30f,20f,65f,40f);
            PdfWriter pw = PdfWriter.GetInstance(document, /*fs*/ ms);
            string panthImage = Server.MapPath("/Vistas/assets/img/Negritos.jpg");            
            string numcompro = this.Lblnumcompro.Text;           
          
            pw.PageEvent = new HeaderFooter(panthImage, numcompro);            

            document.Open();           
            string nameFont = Server.MapPath("/Vistas/font/Megan June.otf"); 
            BaseFont bf = BaseFont.CreateFont(nameFont, BaseFont.CP1250,BaseFont.EMBEDDED);           
            Font fonTex = new Font(bf,15,0,BaseColor.BLACK);
            Font fonTexTitle = new Font(bf, 17, 0, BaseColor.BLUE);
            Font fonTexdeduc = new Font(bf, 15, 0, BaseColor.RED);
            Font fonTexsaldo = new Font(bf, 15, 0, BaseColor.BLUE);
            document.Add(new Paragraph(centro +"    " +mes +" "+anio, fonTex));
            document.Add(new Paragraph(centro + quincenas+ terminoquincena + " "+"Quincena"+"                           Banco:"+" "+bancos, fonTex));
            document.Add(new Paragraph(centro + "                                                 Moneda de Pago:" +" " + monedapagada, fonTex));
            //document.Add(new Paragraph(centro));
            document.Add(new Paragraph(centro1 + "Nombre:" + " " + nombredoc + " " + apellidos, fonTex));
            document.Add(new Paragraph("_________________________________________________________________________________________________________", fonTex));           
            document.Add(new Paragraph(centro));           
            document.Add(new Paragraph("Salario Quincenal"+centro+ "                                       ₡" + salarioquince, fonTexsaldo));
            document.Add(new Paragraph("Permisos sin goce Salario" +centro2 + diassingoce + "                                                      ₡" + totalsingoce, fonTex));
            document.Add(new Paragraph("Comisión Productividad"+centro+ "                            ₡" + comisionp, fonTex));
            document.Add(new Paragraph("Préstamo" + centro + "                                                  " + prestamos, fonTex));
            document.Add(new Paragraph("Feriados" + centro2 +"                             "+ diasferi + "                                                     ₡" + totadericompro, fonTex));
            document.Add(new Paragraph("Extras" + centro2 +"                                " + horasEx + "                                                     ₡" + totaExtra, fonTex));
            document.Add(new Paragraph("Salario Neto" + centro + "                                               " + netocompro, fonTexsaldo));
            document.Add(new Paragraph(centro));
            document.Add(new Paragraph("Deducciones", fonTexTitle));
            document.Add(new Paragraph("CCSS" + centro2 + "                                  " + porcencaja + "                                                   ₡" + totacajacompro, fonTex));
            document.Add(new Paragraph("Impuesto Renta" + centro + "                                         ₡" + impuestorenta, fonTex));
            document.Add(new Paragraph("Otras deducciones" + centro + "                                     ₡" + otradeduc, fonTex));
            document.Add(new Paragraph("Por concepto de:"+" "+"("+detallededuc+")", fonTex));
            document.Add(new Paragraph("Total Deducciones" + centro + "                                      ₡" + totaldeduc, fonTexdeduc));
            document.Add(new Paragraph(centro));
            document.Add(new Paragraph("Totales", fonTexTitle));
            document.Add(new Paragraph("Total Depositado" + centro + "                                        ₡" + totaldepo, fonTex));
            document.Add(new Paragraph("Saldo Anterior" + centro + "                                           -₡" + saldoante, fonTex));
            document.Add(new Paragraph("Saldo" + centro + "                                                           ₡" + saldocompro, fonTexsaldo));
            document.Add(new Paragraph(centro));
            document.Add(new Paragraph(centro));
            document.Add(new Paragraph(centro));
            document.Add(new Paragraph(centro2 +"                 " +"______________________________", fonTex));
            document.Add(new Paragraph(centro +"      "+ "Recibido", fonTex));

            document.Close();

            byte[] bytesStream = ms.ToArray();
            ms = new MemoryStream();
            ms.Write(bytesStream,0,bytesStream.Length);
            ms.Position = 0;
            Response.Buffer = true;
            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            Response.ContentType = "application/text/PDF";
            Response.AddHeader("content-disposition", "filename=" + this.txt_Nombre.Text +"-"+ quincenas + "-" + mes +"-"+ anio + ".pdf");
            Response.BinaryWrite(bytesStream);
            Response.Flush();
            Response.End();
            return new FileStreamResult(ms,"application/pdf");
            //return null;
        }

        protected void Bntpdf_Click(object sender, EventArgs e)
        {
            pdf();
        }
    }

    class HeaderFooter : PdfPageEventHelper {

        string PathImage = null;
        string NumeroComprobante = null;
        public HeaderFooter(string logoPath, string numcompro) {

            PathImage = logoPath;
            NumeroComprobante = numcompro;
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            //-------------------------------------------------Foo-------------------------------------------
            PdfPTable tbHeader = new PdfPTable(3);
            tbHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            tbHeader.DefaultCell.Border = 0;           
            tbHeader.AddCell(new Paragraph());

            PdfPCell _cell = new PdfPCell(new Paragraph("Comprobante de Pago Salarial"));            
            _cell.HorizontalAlignment = Element.ALIGN_CENTER;
            _cell.Border = 0;           

            tbHeader.AddCell(_cell);

            _cell = new PdfPCell(new Paragraph("N°"+ NumeroComprobante));
            _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            _cell.Border = 0;

            tbHeader.AddCell(_cell);
            tbHeader.AddCell(new Paragraph());          
            tbHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) + 30, writer.DirectContent);
            
          
            
            //-------------------------------------------------Footer-------------------------------------------
            PdfPTable tbFooder = new PdfPTable(3);
            tbFooder.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            tbFooder.DefaultCell.Border = 0;
            tbFooder.AddCell(new Paragraph());
           

            _cell = new PdfPCell(new Paragraph("Coorporación Los negritos S.A"));
            _cell.HorizontalAlignment = Element.ALIGN_CENTER;
            _cell.Border = 0;

            tbFooder.AddCell(_cell);
           

            _cell = new PdfPCell(new Paragraph("Pagina" + writer.PageNumber));
            _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            _cell.Border = 0;

            tbFooder.AddCell(_cell);            
            tbFooder.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetBottom(document.BottomMargin) -5, writer.DirectContent);

            //Inicio imagen
           
            Image logo = Image.GetInstance(PathImage);
            logo.SetAbsolutePosition(document.LeftMargin,writer.PageSize.GetTop(document.TopMargin + 40));
            logo.ScaleAbsolute(135f, 135f);
            document.Add(logo);


            //final de imagen
        }
    }

   
}