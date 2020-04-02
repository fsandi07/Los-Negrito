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

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJxml.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@Axml";
                parParameter[1].SqlDbType = SqlDbType.VarBinary;
                parParameter[1].Size = 250000;
                parParameter[1].SqlValue = OBJxml.Xml;              


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

        public void borrarxml()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJxml.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@numFactura";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = (100);
                parParameter[1].SqlValue = OBJxml.NumFactura;



                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPBorrar_De_Xml");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

     
        }



    }
}
