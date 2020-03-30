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
    public class Ingresar_Pollinaza_Helper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get 
        Ingreso_Pollinaza OBJPollinaza = null;

        public Ingresar_Pollinaza_Helper(Ingreso_Pollinaza parObjPollinaza)
        {
            OBJPollinaza = parObjPollinaza;
        }



        public void Agrergar_Ingreso_Pollinaza()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[14];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJPollinaza.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_ingreso_polli";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = OBJPollinaza.Id_ingreso_polli;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@id_partida";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJPollinaza.Id_partida;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@estado_pago";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = OBJPollinaza.Estado_pago;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@plazo_pago";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = OBJPollinaza.Plazo_pago;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@numero_factura";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = OBJPollinaza.Numero_factura;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@nombre_cliente";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 60;
                parParameter[6].SqlValue = OBJPollinaza.Nomnbre_cliente;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@fecha_emision";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = OBJPollinaza.Fecha_emision;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@cantidad_sacos";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 50;
                parParameter[8].SqlValue = OBJPollinaza.Cantidad_sacos;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@precio_unidad";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 50;
                parParameter[9].SqlValue = OBJPollinaza.Precio_unidad;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@total_pago";
                parParameter[10].SqlDbType = SqlDbType.VarChar;
                parParameter[10].Size = 50;
                parParameter[10].SqlValue = OBJPollinaza.Total_pago;

                parParameter[11] = new SqlParameter();
                parParameter[11].ParameterName = "@pdf_comprobante";
                parParameter[11].SqlDbType = SqlDbType.VarBinary;
                parParameter[11].Size = 8000;
                parParameter[11].SqlValue = OBJPollinaza.Pdf_comprobante;

                parParameter[12] = new SqlParameter();
                parParameter[12].ParameterName = "@nombre_pdf";
                parParameter[12].SqlDbType = SqlDbType.VarChar;
                parParameter[12].Size = 50;
                parParameter[12].SqlValue = OBJPollinaza.Nombre_pdf;

                parParameter[13] = new SqlParameter();
                parParameter[13].ParameterName = "@estado";
                parParameter[13].SqlDbType = SqlDbType.VarChar;
                parParameter[13].Size = 50;
                parParameter[13].SqlValue = OBJPollinaza.Estado;


                cnGeneral.EjecutarSP(parParameter, "SP_los_negritos_Ingreso_polli");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
