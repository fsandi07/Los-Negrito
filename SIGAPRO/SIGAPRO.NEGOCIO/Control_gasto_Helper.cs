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
   public class Control_gasto_Helper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get 
        Control_gasto OBJControl = null;


        public Control_gasto_Helper(Control_gasto parObjcontrol)
        {
            OBJControl = parObjcontrol;
        }

        public void Agregar_Control()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[7];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJControl.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_control";
                parParameter[1].SqlDbType = SqlDbType.Int;           
                parParameter[1].SqlValue = OBJControl.Id_control;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@periodo";
                parParameter[2].SqlDbType = SqlDbType.Int;               
                parParameter[2].SqlValue = OBJControl.Periodo;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@Centro_costos";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 40;
                parParameter[3].SqlValue = OBJControl.Id_centro_costos;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@id_partida";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = OBJControl.Id_partidas;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@monto_total";
                parParameter[5].SqlDbType = SqlDbType.Float;
                parParameter[5].SqlValue = OBJControl.Total;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@numero_factura";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = OBJControl.Num_factura;

                cnGeneral.EjecutarSP(parParameter, "SP_los_negritos_Controles");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
