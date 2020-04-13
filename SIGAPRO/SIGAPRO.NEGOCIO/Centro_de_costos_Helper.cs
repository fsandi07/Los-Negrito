using MVC.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Centro_de_costos_Helper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get 
        centro_de_costos OBJc_costos = null;

        public Centro_de_costos_Helper(centro_de_costos parObjc_partidas)
        {
            OBJc_costos = parObjc_partidas;
        }

        public void Agrergar_centro_costos()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[4];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJc_costos.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@numero_centro_costos";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = OBJc_costos.Numero_centro_costos;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@descripcion ";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJc_costos.Descripcion;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@estado_cc";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = OBJc_costos.Estado;

                cnGeneral.EjecutarSP(parParameter, "SP_los_negritos_centro_de_costos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Modificar_centro_costos()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[4];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJc_costos.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@numero_centro_costos";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = OBJc_costos.Numero_centro_costos;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@descripcion ";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJc_costos.Descripcion;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@estado_cc";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = OBJc_costos.Estado;

                cnGeneral.EjecutarSP(parParameter, "SP_los_negritos_centro_de_costos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
