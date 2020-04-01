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
    public class Egreso_Manual_Helper
    {

        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get         
        Egreso_manual OBJEgresoM = null;

        public Egreso_Manual_Helper(Egreso_manual parObjEgresoM)
        {
            OBJEgresoM = parObjEgresoM;
        }


        public void Agrergar_Egreso_manual()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[22];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJEgresoM.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_egreso";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = OBJEgresoM.Id_egreso;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@digital";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJEgresoM.Digital;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@fecha_registro";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = OBJEgresoM.Fecha_registro;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@numero_factura";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = OBJEgresoM.Numero_factura;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@fisica";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = OBJEgresoM.Fisica;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@gti";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = OBJEgresoM.Gti;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@nombre_comercio";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = OBJEgresoM.Nombre_comercio;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@id_detalle";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 50;
                parParameter[8].SqlValue = OBJEgresoM.Id_detalle;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@id_partida";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 50;
                parParameter[9].SqlValue = OBJEgresoM.Id_partida;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@monto_factura";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 50;
                parParameter[10].SqlValue = OBJEgresoM.Monto_factura;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@estado_pago";
                parParameter[11].SqlDbType = SqlDbType.VarChar;
                parParameter[11].Size = 50;
                parParameter[11].SqlValue = OBJEgresoM.Estado_pago;

                parParameter[12] = new SqlParameter();
                parParameter[12].ParameterName = "@plazo_pago";
                parParameter[12].SqlDbType = SqlDbType.VarChar;
                parParameter[12].Size = 50;
                parParameter[12].SqlValue = OBJEgresoM.Plazo_pago;

                parParameter[13] = new SqlParameter();
                parParameter[13].ParameterName = "@pdf_factura";
                parParameter[13].SqlDbType = SqlDbType.VarBinary;
                parParameter[13].Size = 8000;
                parParameter[13].SqlValue = OBJEgresoM.Pdf_factura;

                parParameter[14] = new SqlParameter();
                parParameter[14].ParameterName = "@nombre_pdf";
                parParameter[14].SqlDbType = SqlDbType.VarChar;
                parParameter[14].Size = 100;
                parParameter[14].SqlValue = OBJEgresoM.Nombre_pdf;

                parParameter[15] = new SqlParameter();
                parParameter[15].ParameterName = "@id_centroCostos";
                parParameter[15].SqlDbType = SqlDbType.VarChar;
                parParameter[15].Size = 50;
                parParameter[15].SqlValue = OBJEgresoM.Id_centroCostos;

                parParameter[16] = new SqlParameter();
                parParameter[16].ParameterName = "@estado";
                parParameter[16].SqlDbType = SqlDbType.VarChar;
                parParameter[16].Size = 50;
                parParameter[16].SqlValue = OBJEgresoM.Estado;

                parParameter[17] = new SqlParameter();
                parParameter[17].ParameterName = "@id_banco";
                parParameter[17].SqlDbType = SqlDbType.VarChar;
                parParameter[17].Size = 50;
                parParameter[17].SqlValue = OBJEgresoM.Id_banco;

                parParameter[18] = new SqlParameter();
                parParameter[18].ParameterName = "@id_metodo_pago";
                parParameter[18].SqlDbType = SqlDbType.VarChar;
                parParameter[18].Size = 50;
                parParameter[18].SqlValue = OBJEgresoM.Id_metodo_pago;

                parParameter[19] = new SqlParameter();
                parParameter[19].ParameterName = "@Moneda";
                parParameter[19].SqlDbType = SqlDbType.VarChar;
                parParameter[19].Size = 50;
                parParameter[19].SqlValue = OBJEgresoM.Moneda;

                parParameter[20] = new SqlParameter();
                parParameter[20].ParameterName = "@pocentIva";
                parParameter[20].SqlDbType = SqlDbType.VarChar;
                parParameter[20].Size = 50;
                parParameter[20].SqlValue = OBJEgresoM.PorcenIva;

                parParameter[21] = new SqlParameter();
                parParameter[21].ParameterName = "@totalIva";
                parParameter[21].SqlDbType = SqlDbType.VarChar;
                parParameter[21].Size = 50;
                parParameter[21].SqlValue = OBJEgresoM.TotalIva;

                cnGeneral.EjecutarSP(parParameter, "SP_egreso_manual_los_Negritos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}