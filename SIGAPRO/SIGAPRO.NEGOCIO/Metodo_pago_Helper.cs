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

    public class Metodo_pago_Helper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
     Metodo_pagos OBJumetodo = null;

        public Metodo_pago_Helper(Metodo_pagos parObjmetodo)
        {
            OBJumetodo = parObjmetodo;
        }
        //public DataTable validarusuario()
        //{
        //    tblDatos = new DataTable();
        //    try
        //    {
        //        cnGeneral = new Datos();

        //        SqlParameter[] parParameter = new SqlParameter[3];

        //        parParameter[0] = new SqlParameter();
        //        parParameter[0].ParameterName = "@opcion";
        //        parParameter[0].SqlDbType = SqlDbType.Int;
        //        parParameter[0].SqlValue = OBJusuarios.Opc;

        //        // validar usuarios.
        //        parParameter[1] = new SqlParameter();
        //        parParameter[1].ParameterName = "@nick_name";
        //        parParameter[1].SqlDbType = SqlDbType.VarChar;
        //        parParameter[1].Size = 50;
        //        parParameter[1].SqlValue = OBJusuarios.Nick_name;

        //        parParameter[2] = new SqlParameter();
        //        parParameter[2].ParameterName = "@clave_usuario";
        //        parParameter[2].SqlDbType = SqlDbType.VarChar;
        //        parParameter[2].Size = 50;
        //        parParameter[2].SqlValue = OBJusuarios.Clave_usuario;

        //        tblDatos = cnGeneral.RetornaTabla(parParameter, "SPValidacionUsu_los_negritos");

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }


        //    return tblDatos;
        //}
        //// Agregar Usuarios
        public void Agregar_metodo_pago()
        {
            try
            {
                cnGeneral = new Datos();
                SqlParameter[] parParameter = new SqlParameter[5];
                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = OBJumetodo.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre_metodo";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = OBJumetodo.Nombre_metodo;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@Descripcion";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 150;
                parParameter[2].SqlValue = OBJumetodo.Descripcion_metodo;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@num_referencia";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 100;
                parParameter[3].SqlValue = OBJumetodo.Num_referencia;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@estado";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = OBJumetodo.Estado;

                cnGeneral.EjecutarSP(parParameter, "SPUsuario_metodo_pago");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    //    public DataTable Listar_Usuarios()
    //    {
    //        tblDatos = new DataTable();
    //        try
    //        {
    //            cnGeneral = new Datos();
    //            SqlParameter[] parParameter = new SqlParameter[1];
    //            parParameter[0] = new SqlParameter();
    //            parParameter[0].ParameterName = "@opcion";
    //            parParameter[0].SqlDbType = SqlDbType.Int;
    //            parParameter[0].SqlValue = OBJusuarios.Opc;

    //            tblDatos = cnGeneral.RetornaTabla(parParameter, "SPUsuario_los_negritos");
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception(ex.Message);
    //        }
    //        return tblDatos;
    //    }


    }
}

    

