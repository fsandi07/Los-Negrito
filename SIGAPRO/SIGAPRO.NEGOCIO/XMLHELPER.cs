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
   public class XMLHELPER
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get 
        DatosXML OBJxml = null;

        public XMLHELPER(DatosXML parObjxml)
        {
            OBJxml = parObjxml;
        }
        public void enviarxml()
        {

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJxml.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Axml";
                parParameter[1].SqlDbType = SqlDbType.VarBinary;
                parParameter[1].Size = 250000;
                parParameter[1].SqlValue = OBJxml.Xml;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@aceptada_gti";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 100;
                parParameter[2].SqlValue = OBJxml.Aceptada_gti;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@archivo_pdf";
                parParameter[3].SqlDbType = SqlDbType.VarBinary;
                parParameter[3].Size = 250000;
                parParameter[3].SqlValue = OBJxml.Archivo_pdf;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@cuenta_por_pagar";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 100;
                parParameter[4].SqlValue = OBJxml.Cuenta_por_pagar;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@factura_fisica";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 100;
                parParameter[5].SqlValue = OBJxml.Factura_fisica;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@detalle";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 100;
                parParameter[6].SqlValue = OBJxml.Detalle;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@vencimiento";
                parParameter[7].SqlDbType = SqlDbType.Date;
                parParameter[7].SqlValue = OBJxml.Vencimiento;


                cnGeneral.EjecutarSP(parParameter,"SPExtraccion_De_Xml");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }

        public DataTable mostrarxml()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJxml.Opc;
                tblDatos = cnGeneral.RetornaTabla(parParameter,"SPextracion");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }



    }
}
