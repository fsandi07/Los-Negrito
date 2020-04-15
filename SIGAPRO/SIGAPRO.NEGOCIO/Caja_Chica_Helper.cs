using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MVC.Modelo;

namespace SIGAPRO.NEGOCIO
{
    public class Caja_Chica_Helper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get
        Caja_Chica OBJCaja = null;
        
        public Caja_Chica_Helper(Caja_Chica parObjCaja)
        {
            OBJCaja = parObjCaja;
        }

        public void Agregar_Caja()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[6];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJCaja.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre_caja";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 100;
                parParameter[1].SqlValue = OBJCaja.Nombre_Caja;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Descripcion";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 100;
                parParameter[2].SqlValue = OBJCaja.Descripcion1;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@fecha_inicio";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 100;
                parParameter[3].SqlValue = OBJCaja.Fecha_inicio;


                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Saldo_inicio";
                parParameter[4].SqlDbType = SqlDbType.Float;            
                parParameter[4].SqlValue = OBJCaja.Saldo_inicial;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@estado";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = OBJCaja.Estado;

                cnGeneral.EjecutarSP(parParameter, "SP_los_negritos_Ingreso_Caja");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Agregar_Movimiento()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[7];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJCaja.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@detalle";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 100;
                parParameter[1].SqlValue = OBJCaja.Concepto_movimiento;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@fecha_Movi";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJCaja.Fecha_movimiento;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@movimiento";
                parParameter[3].SqlDbType = SqlDbType.Float;             
                parParameter[3].SqlValue = OBJCaja.Movimiento_dinero;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@saldo";
                parParameter[4].SqlDbType = SqlDbType.Float;
                parParameter[4].SqlValue = OBJCaja.Saldo1;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@tipo_movi";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = OBJCaja.Tipo_movimiento;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@id_caja";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = OBJCaja.Id_Caja;

                cnGeneral.EjecutarSP(parParameter, "SP_los_negritos_Ingreso_Caja");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Consulta_Cajas()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJCaja.Opc;
                tblDatos = cnGeneral.RetornaTabla(parParameter, "SP_los_negritos_Ingreso_Caja");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return tblDatos;
        }

        public DataTable Consulta_saldo()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJCaja.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_caja";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = OBJCaja.Id_Caja;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SP_los_negritos_Ingreso_Caja");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return tblDatos;
        }

    }
}
