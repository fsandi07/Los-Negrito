using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace SIGAPRO.NEGOCIO
{
   public  class Pago_empleado_Helper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get 
        Pagos_empleados OBJPagos_empleados = null;

        public Pago_empleado_Helper(Pagos_empleados parPagos_empleados)
        {
            OBJPagos_empleados = parPagos_empleados;
        }

        public void Agregar_pago_Empleado()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[25];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJPagos_empleados.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula_empleado ";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = OBJPagos_empleados.Cedula_empleado;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@salario_quincenal";
                parParameter[2].SqlDbType = SqlDbType.Float;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = OBJPagos_empleados.Salario_quincenal;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@prestamo";
                parParameter[3].SqlDbType = SqlDbType.Float;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = OBJPagos_empleados.Prestamo;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@banco";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 40;
                parParameter[4].SqlValue = OBJPagos_empleados.Banco;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@moneda";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = OBJPagos_empleados.Moneda;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@quincena";
                parParameter[6].SqlDbType = SqlDbType.Int;            ;
                parParameter[6].SqlValue = OBJPagos_empleados.Quincena;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@mes_a_pagar";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = OBJPagos_empleados.Mes_a_pagar;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@dias_sin_goce";
                parParameter[8].SqlDbType = SqlDbType.Int;
                parParameter[8].SqlValue = OBJPagos_empleados.Dias_sin_goce;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@perdido_dias_sin_goce";
                parParameter[9].SqlDbType = SqlDbType.Float;
                parParameter[9].Size = 30;
                parParameter[9].SqlValue = OBJPagos_empleados.Perdido_dias_sin_goce;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@comision_productividad";
                parParameter[10].SqlDbType = SqlDbType.Float;
                parParameter[10].Size = 30;
                parParameter[10].SqlValue = OBJPagos_empleados.Comision_productividad;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@ganado_feriados";
                parParameter[11].SqlDbType = SqlDbType.Float;
                parParameter[11].Size = 30;
                parParameter[11].SqlValue = OBJPagos_empleados.Ganado_feriados;

                parParameter[12] = new SqlParameter();
                parParameter[12].ParameterName = "@dias_feriados";
                parParameter[12].SqlDbType = SqlDbType.Int;
                parParameter[12].SqlValue = OBJPagos_empleados.Dias_feriados;

                parParameter[13] = new SqlParameter();
                parParameter[13].ParameterName = "@ganado_extras";
                parParameter[13].SqlDbType = SqlDbType.Float;
                parParameter[13].Size = 30;
                parParameter[13].SqlValue = OBJPagos_empleados.Ganado_extras;

                parParameter[14] = new SqlParameter();
                parParameter[14].ParameterName = "@horas_extras";
                parParameter[14].SqlDbType = SqlDbType.Int;
                parParameter[14].SqlValue = OBJPagos_empleados.Horas_extras;

                parParameter[15] = new SqlParameter();
                parParameter[15].ParameterName = "@salario_neto";
                parParameter[15].SqlDbType = SqlDbType.Float;
                parParameter[15].Size = 30;
                parParameter[15].SqlValue = OBJPagos_empleados.Salario_neto;

                parParameter[16] = new SqlParameter();
                parParameter[16].ParameterName = "@caja_seguro";
                parParameter[16].SqlDbType = SqlDbType.Float;
                parParameter[16].Size = 30;
                parParameter[16].SqlValue = OBJPagos_empleados.Caja_seguro;

                parParameter[17] = new SqlParameter();
                parParameter[17].ParameterName = "@impuesto_renta";
                parParameter[17].SqlDbType = SqlDbType.Float;
                parParameter[17].Size = 30;
                parParameter[17].SqlValue = OBJPagos_empleados.Impuesto_renta;

                parParameter[18] = new SqlParameter();
                parParameter[18].ParameterName = "@otras_deducciones";
                parParameter[18].SqlDbType = SqlDbType.Float;
                parParameter[18].Size = 30;
                parParameter[18].SqlValue = OBJPagos_empleados.Otras_deducciones;

                parParameter[19] = new SqlParameter();
                parParameter[19].ParameterName = "@descri_otyras-deducc";
                parParameter[19].SqlDbType = SqlDbType.VarChar;
                parParameter[19].Size =500;
                parParameter[19].SqlValue = OBJPagos_empleados.Descri_otras_deducc;

                parParameter[20] = new SqlParameter();
                parParameter[20].ParameterName = "@total_deducciones";
                parParameter[20].SqlDbType = SqlDbType.Float;
                parParameter[20].Size = 30;
                parParameter[20].SqlValue = OBJPagos_empleados.Total_deducciones;

                parParameter[21] = new SqlParameter();
                parParameter[21].ParameterName = "@total_depositado";
                parParameter[21].SqlDbType = SqlDbType.Float;
                parParameter[21].Size = 30;
                parParameter[21].SqlValue = OBJPagos_empleados.Total_depositado;

                parParameter[22] = new SqlParameter();
                parParameter[22].ParameterName = "@total_anterior";
                parParameter[22].SqlDbType = SqlDbType.Float;
                parParameter[22].Size = 30;
                parParameter[22].SqlValue = OBJPagos_empleados.Total_anterior;

                parParameter[23] = new SqlParameter();
                parParameter[23].ParameterName = "@saldo";
                parParameter[23].SqlDbType = SqlDbType.Float;
                parParameter[23].Size = 30;
                parParameter[23].SqlValue = OBJPagos_empleados.Saldo;

                parParameter[24] = new SqlParameter();
                parParameter[24].ParameterName = "@boleta_entregada";
                parParameter[24].SqlDbType = SqlDbType.Int;
                parParameter[24].SqlValue = OBJPagos_empleados.Boleta_entregada;


                cnGeneral.EjecutarSP(parParameter, "SPpago_empleados_los_negritos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
