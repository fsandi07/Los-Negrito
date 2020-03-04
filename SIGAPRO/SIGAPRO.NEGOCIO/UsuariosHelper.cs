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
   public class UsuariosHelper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        // llama a mi clase cliente donde tengo mis constructores, set and get 
        Usuarios OBJusuarios = null;

        public UsuariosHelper(Usuarios parObjusuarios)
        {
            OBJusuarios = parObjusuarios;
        }
        // validar usuarios
        public DataTable validarusuario()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJusuarios.Opc;

                // validar usuarios.
                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nick_name";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = OBJusuarios.Nick_name;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@clave_usuario";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJusuarios.Clave_usuario;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPValidacionUsu_los_negritos");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


            return tblDatos;
        }
        // Agregar Usuarios
        public void Agregar_Usuarios()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[10];
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJusuarios.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula_usuario ";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = OBJusuarios.Cedula_usuario;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre_usuario";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = OBJusuarios.Nombre_usuario;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@apellido1";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = OBJusuarios.Apellido1;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@apellido2";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = OBJusuarios.Apellido2;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@nick_name";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = OBJusuarios.Nick_name;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@correo_electronico";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = OBJusuarios.Correo_electronico;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@clave_usuario";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = OBJusuarios.Clave_usuario;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@rol";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 50;
                parParameter[8].SqlValue = OBJusuarios.Rol;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@estado";
                parParameter[9].SqlDbType = SqlDbType.Int;
                parParameter[9].SqlValue = OBJusuarios.Estado;

                cnGeneral.EjecutarSP(parParameter, "SPUsuario_los_negritos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
