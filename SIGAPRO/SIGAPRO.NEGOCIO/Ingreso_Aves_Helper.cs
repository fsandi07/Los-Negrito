using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MVC.Modelo;
using System;

namespace SIGAPRO.NEGOCIO
{
   public class Ingreso_Aves_Helper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get 
        Ingreso_Aves OBJIngreAves = null;

        public Ingreso_Aves_Helper(Ingreso_Aves parObjIngreAves)
        {
            OBJIngreAves = parObjIngreAves;
        }
        public void Agrergar_Ingreso_aves()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[19];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJIngreAves.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_ingreso_aves";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = OBJIngreAves.Id_ingreso_aves;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@id_partida";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJIngreAves.Id_partida;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@estado_pago";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = OBJIngreAves.Estado_pago;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@plazo_pago";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = OBJIngreAves.Plazo_pago;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@numero_factura";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = OBJIngreAves.Numero_factura;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@fecha_emision";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = OBJIngreAves.Fecha_emision;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@monto_factura";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = OBJIngreAves.Monto_factura;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@detalle_factura";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 50;
                parParameter[8].SqlValue = OBJIngreAves.Detalle_factura;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@porcent_iva";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 50;
                parParameter[9].SqlValue = OBJIngreAves.Porcent_iva;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@total_iva";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 50;
                parParameter[10].SqlValue = OBJIngreAves.Total_iva;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@total_menos_iva";
                parParameter[11].SqlDbType = SqlDbType.VarChar;
                parParameter[11].Size = 50;
                parParameter[11].SqlValue = OBJIngreAves.Total_menos_iva;

                parParameter[12] = new SqlParameter();
                parParameter[12].ParameterName = "@total_menos_otros_iva";
                parParameter[12].SqlDbType = SqlDbType.VarChar;
                parParameter[12].Size = 50;
                parParameter[12].SqlValue = OBJIngreAves.Total_menos_otros_iva;

                parParameter[13] = new SqlParameter();
                parParameter[13].ParameterName = "@estado";
                parParameter[13].SqlDbType = SqlDbType.VarChar;
                parParameter[13].Size = 50;
                parParameter[13].SqlValue = OBJIngreAves.Estado;

                parParameter[14] = new SqlParameter();
                parParameter[14].ParameterName = "@nombre_pdf";
                parParameter[14].SqlDbType = SqlDbType.VarChar;
                parParameter[14].Size = 50;
                parParameter[14].SqlValue = OBJIngreAves.Nombre_pdf;

                parParameter[15] = new SqlParameter();
                parParameter[15].ParameterName = "@nombre_comercio";
                parParameter[15].SqlDbType = SqlDbType.VarChar;
                parParameter[15].Size = 50;
                parParameter[15].SqlValue = OBJIngreAves.Nombre_comercio;

                parParameter[16] = new SqlParameter();
                parParameter[16].ParameterName = "@pd_comprobante";
                parParameter[16].SqlDbType = SqlDbType.VarBinary;
                parParameter[16].Size = 9000;
                parParameter[16].SqlValue = OBJIngreAves.Pdf_comprobante;

                parParameter[17] = new SqlParameter();
                parParameter[17].ParameterName = "@monto_otra_carga";
                parParameter[17].SqlDbType = SqlDbType.VarChar;
                parParameter[17].Size = 50;
                parParameter[17].SqlValue = OBJIngreAves.Monto_otra_carga;

                parParameter[18] = new SqlParameter();
                parParameter[18].ParameterName = "@detalle_otra_carga";
                parParameter[18].SqlDbType = SqlDbType.VarChar;
                parParameter[18].Size = 50;
                parParameter[18].SqlValue = OBJIngreAves.Detalle_otra_carga;

                cnGeneral.EjecutarSP(parParameter, "SP_los_negritos_Ingreso_aves");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
