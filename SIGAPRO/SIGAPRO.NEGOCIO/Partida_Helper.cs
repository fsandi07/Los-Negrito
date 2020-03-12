using MVC.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SIGAPRO.NEGOCIO
{
    public class Partida_Helper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get 
        Partidas OBJpartidas = null;

        public Partida_Helper(Partidas parObjpartidas)
        {
            OBJpartidas = parObjpartidas;
        }
        public void Agrergar_partida()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[6];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJpartidas.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@numero_partida ";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = OBJpartidas.Numero_partida;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@descripcion ";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJpartidas.Descripcion;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName ="@fecha_inicio";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = OBJpartidas.Fecha_inicio;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@fecha_finla";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = OBJpartidas.Fecha_final;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@numero_factura";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 100;
                parParameter[5].SqlValue = OBJpartidas.Numero_factura;

                cnGeneral.EjecutarSP(parParameter, "SPpartidas_los_negritos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
