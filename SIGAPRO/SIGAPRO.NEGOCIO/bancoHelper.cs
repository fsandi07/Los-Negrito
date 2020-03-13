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
   public  class bancoHelper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get 
        Bancos OBJbancos = null;

        public bancoHelper(Bancos parObjbanco)
        {
            OBJbancos = parObjbanco;
        }


        public void Agrergar_Bancos()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[4];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJbancos.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre_banco";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 100;
                parParameter[1].SqlValue =OBJbancos.Nombre_banco;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Descripcion";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 100;
                parParameter[2].SqlValue =OBJbancos.Descripcion1 ;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@cuenta_iban";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 100;
                parParameter[3].SqlValue =OBJbancos.Cuenta_iban ;

                cnGeneral.EjecutarSP(parParameter, "SP_los_negritos_bancos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
