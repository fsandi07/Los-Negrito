using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using SIGAPRO.NEGOCIO;

namespace SIGAPRO.Vistas
{
    public partial class Registro_pagos : System.Web.UI.Page

    {

        private DataTable datos;
        private Empleados emple;
        private Empleados_Helper empleHelper;
        private Pago_Empleados pagoemple;
        private Pago_Empleados_Helper pagoempleHelper;

        protected void Page_Load(object sender, EventArgs e)
        {

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
       
        protected void btn_Pago_Cola_Click(object sender, EventArgs e)
        {
            try
            {
                this.pagoemple = new Pago_Empleados();
                this.pagoemple.Opc = 1;
                this.pagoemple.Id_comprobante = int.Parse(this.Lblnumcompro.Text);
                this.pagoemple.Mes = this.DptMes.SelectedValue;
                this.pagoemple.Anio = this.Dptyear.SelectedValue;
                this.pagoemple.Quincena = int.Parse(this.Dpquincena.SelectedValue);
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
                this.pagoemple.Realname_pdf = this.file_pdf.FileName;


                this.pagoempleHelper = new Pago_Empleados_Helper(pagoemple);
                this.pagoempleHelper.Agregar_pago_empleado();

                Limpiar();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mmensajeDeconfirmacion", "mensajeDeconfirmacion('" + "" + "');", true);
                

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "mensajeError", "mensajeError('" + "" + "');", true);
            }
        }
        public void Limpiar()
        {

            this.Lblnumcompro.Text = null;
            this.DptMes.SelectedValue = null;
            this.Dptyear.SelectedValue = null;
            this.Dpquincena.SelectedValue = null;
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


    }
}