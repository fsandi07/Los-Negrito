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
    public  class Pago_Empleados_Helper
    {

        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get 
        Pago_Empleados OBJpagoemple = null;

        public Pago_Empleados_Helper(Pago_Empleados parObjpagoemple)
        {
            OBJpagoemple = parObjpagoemple;
        }

        // Agregar Usuarios
        public void Agregar_pago_empleado()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[32];
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJpagoemple.Opc;                

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@mes";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = OBJpagoemple.Mes;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@periodo";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJpagoemple.Anio;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@quincena";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = OBJpagoemple.Quincena;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@moneda";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = OBJpagoemple.Moneda;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@fecha_registro ";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = OBJpagoemple.Fecha_registro;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@id_colaborador";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = OBJpagoemple.Id_colaborador;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@salario_quincenal";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = OBJpagoemple.Salario_quincenal;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@comision";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 50;
                parParameter[8].SqlValue = OBJpagoemple.Comision;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@prestamos";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 50;
                parParameter[9].SqlValue = OBJpagoemple.Prestamo;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@dias_sinGoce";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 50;
                parParameter[10].SqlValue = OBJpagoemple.Dias_sinGoce;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@total_sinGoce";
                parParameter[11].SqlDbType = SqlDbType.VarChar;
                parParameter[11].Size = 50;
                parParameter[11].SqlValue = OBJpagoemple.Total_sinGoce;

                parParameter[12] = new SqlParameter();
                parParameter[12].ParameterName = "@dias_feriados";
                parParameter[12].SqlDbType = SqlDbType.VarChar;
                parParameter[12].Size = 50;
                parParameter[12].SqlValue = OBJpagoemple.Dias_feriados;

                parParameter[13] = new SqlParameter();
                parParameter[13].ParameterName = "@total_feriados";
                parParameter[13].SqlDbType = SqlDbType.VarChar;
                parParameter[13].Size = 50;
                parParameter[13].SqlValue = OBJpagoemple.Total_feriados;

                parParameter[14] = new SqlParameter();
                parParameter[14].ParameterName = "@horas_extras";
                parParameter[14].SqlDbType = SqlDbType.VarChar;
                parParameter[14].Size = 50;
                parParameter[14].SqlValue = OBJpagoemple.Horas_extras;

                parParameter[15] = new SqlParameter();
                parParameter[15].ParameterName = "@total_extras";
                parParameter[15].SqlDbType = SqlDbType.VarChar;
                parParameter[15].Size = 50;
                parParameter[15].SqlValue = OBJpagoemple.Total_extras;

                parParameter[16] = new SqlParameter();
                parParameter[16].ParameterName = "@salario_neto";
                parParameter[16].SqlDbType = SqlDbType.VarChar;
                parParameter[16].Size = 50;
                parParameter[16].SqlValue = OBJpagoemple.Salario_neto;

                parParameter[17] = new SqlParameter();
                parParameter[17].ParameterName = "@porcen_caja";
                parParameter[17].SqlDbType = SqlDbType.VarChar;
                parParameter[17].Size = 50;
                parParameter[17].SqlValue = OBJpagoemple.Porcen_caja;

                parParameter[18] = new SqlParameter();
                parParameter[18].ParameterName = "@impuesto_renta";
                parParameter[18].SqlDbType = SqlDbType.VarChar;
                parParameter[18].Size = 50;
                parParameter[18].SqlValue = OBJpagoemple.Impuesto_renta;

                parParameter[19] = new SqlParameter();
                parParameter[19].ParameterName = "@otras_deduc";
                parParameter[19].SqlDbType = SqlDbType.VarChar;
                parParameter[19].Size = 50;
                parParameter[19].SqlValue = OBJpagoemple.Otras_deduc;

                parParameter[20] = new SqlParameter();
                parParameter[20].ParameterName = "@detalle_otras_deduc";
                parParameter[20].SqlDbType = SqlDbType.VarChar;
                parParameter[20].Size = 150;
                parParameter[20].SqlValue = OBJpagoemple.Detalle_otras_deduc;

                parParameter[21] = new SqlParameter();
                parParameter[21].ParameterName = "@total_deduc";
                parParameter[21].SqlDbType = SqlDbType.VarChar;
                parParameter[21].Size = 50;
                parParameter[21].SqlValue = OBJpagoemple.Total_deduc;

                parParameter[22] = new SqlParameter();
                parParameter[22].ParameterName = "@saldo_anterior";
                parParameter[22].SqlDbType = SqlDbType.VarChar;
                parParameter[22].Size = 50;
                parParameter[22].SqlValue = OBJpagoemple.Saldo_anterior;

                parParameter[23] = new SqlParameter();
                parParameter[23].ParameterName = "@saldo";
                parParameter[23].SqlDbType = SqlDbType.VarChar;
                parParameter[23].Size = 50;
                parParameter[23].SqlValue = OBJpagoemple.Saldo;

                parParameter[24] = new SqlParameter();
                parParameter[24].ParameterName = "@total_depositado ";
                parParameter[24].SqlDbType = SqlDbType.VarChar;
                parParameter[24].Size = 50;
                parParameter[24].SqlValue = OBJpagoemple.Total_depositado;

                parParameter[25] = new SqlParameter();
                parParameter[25].ParameterName = "@id_banco";
                parParameter[25].SqlDbType = SqlDbType.VarChar;
                parParameter[25].Size = 50;
                parParameter[25].SqlValue = OBJpagoemple.Id_banco;

                parParameter[26] = new SqlParameter();
                parParameter[26].ParameterName = "@estado";
                parParameter[26].SqlDbType = SqlDbType.VarChar;
                parParameter[26].Size = 50;
                parParameter[26].SqlValue = OBJpagoemple.Estado;

                parParameter[27] = new SqlParameter();
                parParameter[27].ParameterName = "@id_centro_costos";
                parParameter[27].SqlDbType = SqlDbType.VarChar;
                parParameter[27].Size = 50;
                parParameter[27].SqlValue = OBJpagoemple.Id_centro_costos;

                parParameter[28] = new SqlParameter();
                parParameter[28].ParameterName = "@id_comprobante";
                parParameter[28].SqlDbType = SqlDbType.Int;
                parParameter[28].SqlValue = OBJpagoemple.Id_comprobante;

                parParameter[29] = new SqlParameter();
                parParameter[29].ParameterName = "@documentoPDF";
                parParameter[29].SqlDbType = SqlDbType.VarBinary;
                parParameter[29].SqlValue = OBJpagoemple.Pdf_comprobante;

                parParameter[30] = new SqlParameter();
                parParameter[30].ParameterName = "@total_caja";
                parParameter[30].SqlDbType = SqlDbType.VarChar;
                parParameter[30].Size = 50;
                parParameter[30].SqlValue = OBJpagoemple.Total_caja;

                parParameter[31] = new SqlParameter();
                parParameter[31].ParameterName = "@realname_pdf";
                parParameter[31].SqlDbType = SqlDbType.VarChar;
                parParameter[31].Size = 50;
                parParameter[31].SqlValue = OBJpagoemple.Realname_pdf;

                cnGeneral.EjecutarSP(parParameter, "SPpago_emple_los_negritos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void modificar_pago_empleado()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[32];
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJpagoemple.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@mes";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = OBJpagoemple.Mes;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@periodo";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJpagoemple.Anio;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@quincena";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = OBJpagoemple.Quincena;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@moneda";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = OBJpagoemple.Moneda;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@fecha_registro ";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = OBJpagoemple.Fecha_registro;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@id_colaborador";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = OBJpagoemple.Id_colaborador;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@salario_quincenal";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = OBJpagoemple.Salario_quincenal;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@comision";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 50;
                parParameter[8].SqlValue = OBJpagoemple.Comision;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@prestamos";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 50;
                parParameter[9].SqlValue = OBJpagoemple.Prestamo;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@dias_sinGoce";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 50;
                parParameter[10].SqlValue = OBJpagoemple.Dias_sinGoce;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@total_sinGoce";
                parParameter[11].SqlDbType = SqlDbType.VarChar;
                parParameter[11].Size = 50;
                parParameter[11].SqlValue = OBJpagoemple.Total_sinGoce;

                parParameter[12] = new SqlParameter();
                parParameter[12].ParameterName = "@dias_feriados";
                parParameter[12].SqlDbType = SqlDbType.VarChar;
                parParameter[12].Size = 50;
                parParameter[12].SqlValue = OBJpagoemple.Dias_feriados;

                parParameter[13] = new SqlParameter();
                parParameter[13].ParameterName = "@total_feriados";
                parParameter[13].SqlDbType = SqlDbType.VarChar;
                parParameter[13].Size = 50;
                parParameter[13].SqlValue = OBJpagoemple.Total_feriados;

                parParameter[14] = new SqlParameter();
                parParameter[14].ParameterName = "@horas_extras";
                parParameter[14].SqlDbType = SqlDbType.VarChar;
                parParameter[14].Size = 50;
                parParameter[14].SqlValue = OBJpagoemple.Horas_extras;

                parParameter[15] = new SqlParameter();
                parParameter[15].ParameterName = "@total_extras";
                parParameter[15].SqlDbType = SqlDbType.VarChar;
                parParameter[15].Size = 50;
                parParameter[15].SqlValue = OBJpagoemple.Total_extras;

                parParameter[16] = new SqlParameter();
                parParameter[16].ParameterName = "@salario_neto";
                parParameter[16].SqlDbType = SqlDbType.VarChar;
                parParameter[16].Size = 50;
                parParameter[16].SqlValue = OBJpagoemple.Salario_neto;

                parParameter[17] = new SqlParameter();
                parParameter[17].ParameterName = "@porcen_caja";
                parParameter[17].SqlDbType = SqlDbType.VarChar;
                parParameter[17].Size = 50;
                parParameter[17].SqlValue = OBJpagoemple.Porcen_caja;

                parParameter[18] = new SqlParameter();
                parParameter[18].ParameterName = "@impuesto_renta";
                parParameter[18].SqlDbType = SqlDbType.VarChar;
                parParameter[18].Size = 50;
                parParameter[18].SqlValue = OBJpagoemple.Impuesto_renta;

                parParameter[19] = new SqlParameter();
                parParameter[19].ParameterName = "@otras_deduc";
                parParameter[19].SqlDbType = SqlDbType.VarChar;
                parParameter[19].Size = 50;
                parParameter[19].SqlValue = OBJpagoemple.Otras_deduc;

                parParameter[20] = new SqlParameter();
                parParameter[20].ParameterName = "@detalle_otras_deduc";
                parParameter[20].SqlDbType = SqlDbType.VarChar;
                parParameter[20].Size = 150;
                parParameter[20].SqlValue = OBJpagoemple.Detalle_otras_deduc;

                parParameter[21] = new SqlParameter();
                parParameter[21].ParameterName = "@total_deduc";
                parParameter[21].SqlDbType = SqlDbType.VarChar;
                parParameter[21].Size = 50;
                parParameter[21].SqlValue = OBJpagoemple.Total_deduc;

                parParameter[22] = new SqlParameter();
                parParameter[22].ParameterName = "@saldo_anterior";
                parParameter[22].SqlDbType = SqlDbType.VarChar;
                parParameter[22].Size = 50;
                parParameter[22].SqlValue = OBJpagoemple.Saldo_anterior;

                parParameter[23] = new SqlParameter();
                parParameter[23].ParameterName = "@saldo";
                parParameter[23].SqlDbType = SqlDbType.VarChar;
                parParameter[23].Size = 50;
                parParameter[23].SqlValue = OBJpagoemple.Saldo;

                parParameter[24] = new SqlParameter();
                parParameter[24].ParameterName = "@total_depositado ";
                parParameter[24].SqlDbType = SqlDbType.VarChar;
                parParameter[24].Size = 50;
                parParameter[24].SqlValue = OBJpagoemple.Total_depositado;

                parParameter[25] = new SqlParameter();
                parParameter[25].ParameterName = "@id_banco";
                parParameter[25].SqlDbType = SqlDbType.VarChar;
                parParameter[25].Size = 50;
                parParameter[25].SqlValue = OBJpagoemple.Id_banco;

                parParameter[26] = new SqlParameter();
                parParameter[26].ParameterName = "@estado";
                parParameter[26].SqlDbType = SqlDbType.VarChar;
                parParameter[26].Size = 50;
                parParameter[26].SqlValue = OBJpagoemple.Estado;

                parParameter[27] = new SqlParameter();
                parParameter[27].ParameterName = "@id_centro_costos";
                parParameter[27].SqlDbType = SqlDbType.VarChar;
                parParameter[27].Size = 50;
                parParameter[27].SqlValue = OBJpagoemple.Id_centro_costos;

                parParameter[28] = new SqlParameter();
                parParameter[28].ParameterName = "@id_comprobante";
                parParameter[28].SqlDbType = SqlDbType.Int;
                parParameter[28].SqlValue = OBJpagoemple.Id_comprobante;

                parParameter[29] = new SqlParameter();
                parParameter[29].ParameterName = "@documentoPDF";
                parParameter[29].SqlDbType = SqlDbType.VarBinary;
                parParameter[29].SqlValue = OBJpagoemple.Pdf_comprobante;

                parParameter[30] = new SqlParameter();
                parParameter[30].ParameterName = "@total_caja";
                parParameter[30].SqlDbType = SqlDbType.VarChar;
                parParameter[30].Size = 50;
                parParameter[30].SqlValue = OBJpagoemple.Total_caja;

                parParameter[31] = new SqlParameter();
                parParameter[31].ParameterName = "@realname_pdf";
                parParameter[31].SqlDbType = SqlDbType.VarChar;
                parParameter[31].Size = 50;
                parParameter[31].SqlValue = OBJpagoemple.Realname_pdf;

                cnGeneral.EjecutarSP(parParameter,"SPpago_emple_los_negritos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Desactiva_pago()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[3];
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJpagoemple.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_comprobante";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = OBJpagoemple.Id_comprobante;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@estado";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJpagoemple.Estado;

                           

                cnGeneral.EjecutarSP(parParameter, "SPpago_emple_los_negritos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable Consulta_num_pago()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJpagoemple.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_comprobante";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = OBJpagoemple.Id_comprobante;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPpago_emple_los_negritos");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return tblDatos;
        }

    }

}
