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
    public class Clasificacion_Factura_Helper
    {

        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get 
        Clasificacion_Factura OBJclasificacion = null;

        public Clasificacion_Factura_Helper(Clasificacion_Factura parObjc_clasificacion)
        {
            OBJclasificacion = parObjc_clasificacion;
        }
        public void Agrergar_Clasificacion_factura()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[5];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJclasificacion.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre_clasificacion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = OBJclasificacion.Nombre_clasificacion;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@descripcion_clasificacion";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJclasificacion.Descripcion_clasificacion;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@estado_detalle ";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = OBJclasificacion.Estado_detalle;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@id_detalle ";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = OBJclasificacion.Id_detalle;

                cnGeneral.EjecutarSP(parParameter, "SP_los_negritos_detalle_factura");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Modificar_detalle_factura()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[5];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJclasificacion.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre_clasificacion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = OBJclasificacion.Nombre_clasificacion;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@descripcion_clasificacion";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJclasificacion.Descripcion_clasificacion;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@estado_detalle ";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = OBJclasificacion.Estado_detalle;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@id_detalle ";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = OBJclasificacion.Id_detalle;

                cnGeneral.EjecutarSP(parParameter, "SP_los_negritos_detalle_factura");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
