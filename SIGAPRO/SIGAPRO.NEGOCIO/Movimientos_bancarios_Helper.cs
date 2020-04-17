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

    public class Movimientos_bancarios_Helper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        Movimientos_Bancarios OBJMovimientos;

        public Movimientos_bancarios_Helper(Movimientos_Bancarios parObjmovi)
        {
            OBJMovimientos = parObjmovi;
        }
        public void Agregar_movi_banc()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[6];
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJMovimientos.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@idbanco";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = OBJMovimientos.Id_banco;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@detalle";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 100;
                parParameter[2].SqlValue = OBJMovimientos.Detalle_movi;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@fecha";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = OBJMovimientos.Fecha_registro;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@nombre";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = OBJMovimientos.Nombre_movi;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@moneda";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = OBJMovimientos.Moneda;

                cnGeneral.EjecutarSP(parParameter, "SPMovi_bancario_los_negritos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Agregar_trans_banc()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[12];
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJMovimientos.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_trans_banc";
                parParameter[1].SqlDbType = SqlDbType.Int;             
                parParameter[1].SqlValue = OBJMovimientos.Id_trans_banc;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@fecha_trans";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 40;
                parParameter[2].SqlValue = OBJMovimientos.Fecha_movi_regis;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@detalle_trans";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 100;
                parParameter[3].SqlValue = OBJMovimientos.Detalle_registro;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@Cantidad_movi";
                parParameter[4].SqlDbType = SqlDbType.Float;             
                parParameter[4].SqlValue = OBJMovimientos.Cantidad_dinero;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@saldo";
                parParameter[5].SqlDbType = SqlDbType.Float;
                parParameter[5].SqlValue = OBJMovimientos.Saldo;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@item";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = OBJMovimientos.Item;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@Num_factura";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = OBJMovimientos.Numero;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@id_registro_banc";
                parParameter[8].SqlDbType = SqlDbType.Float;
                parParameter[8].SqlValue = OBJMovimientos.Id_registro_banco;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@tipo_movi";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 50;
                parParameter[9].SqlValue = OBJMovimientos.Tipo_registro;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@centroCostos";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 50;
                parParameter[10].SqlValue = OBJMovimientos.Centro_costos;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@financia";
                parParameter[11].SqlDbType = SqlDbType.Int;
                parParameter[11].SqlValue = OBJMovimientos.Financia;

                cnGeneral.EjecutarSP(parParameter, "SPRegistro_Movi_banc_los_negritos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
                parParameter[0].SqlValue = OBJMovimientos.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_trans_banc";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = OBJMovimientos.Id_registro_banco;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPRegistro_Movi_banc_los_negritos");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return tblDatos;
        }



    }
}
