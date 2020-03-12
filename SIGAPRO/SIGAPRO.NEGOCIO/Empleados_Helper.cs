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
    public class Empleados_Helper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get 
        Empleados OBJempleados = null;

        public Empleados_Helper(Empleados parObjempleados)
        {
            OBJempleados = parObjempleados;
        }
        public void Agregar_pago_Empleado()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[25];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJempleados.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula_empleado ";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 40;
                parParameter[1].SqlValue = OBJempleados.Cedula_empleado;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre_empleado";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 40;
                parParameter[2].SqlValue = OBJempleados.Nombre_empelado;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@apellido1_empleado";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 40;
                parParameter[3].SqlValue = OBJempleados.Apellido1_empleado;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@aepllido2_empledo";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 40;
                parParameter[4].SqlValue = OBJempleados.Apellido2_empleado;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@domicilio";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = OBJempleados.Domicilio;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@telefono_empleado";
                parParameter[6].SqlDbType = SqlDbType.Int; ;
                parParameter[6].SqlValue = OBJempleados.Telefono_empleado;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@correo_empleado";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = OBJempleados.Correo_empleado;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@cuenta_banco_empleado";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 50;
                parParameter[8].SqlValue = OBJempleados.Cuenta_banco_empleado;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@fecha_nacimiento_empleado";
                parParameter[9].SqlDbType = SqlDbType.DateTime;
                parParameter[9].SqlValue = OBJempleados.Fecha_nacimientoi_empleado;

                parParameter[10] = new SqlParameter();
                parParameter[10].ParameterName = "@fecha_inicio_empleado";
                parParameter[10].SqlDbType = SqlDbType.DateTime;
                parParameter[10].SqlValue = OBJempleados.Fecha_inicio_empleado;              

                cnGeneral.EjecutarSP(parParameter, "SP_los_negritos_empleado");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
