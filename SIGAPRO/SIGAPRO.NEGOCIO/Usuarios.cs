using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
   public class Usuarios
    {
        private int opc;
        private string cedula_usuario;
        private string nombre_usuario;
        private string apellido1;
        private string apellido2;
        private string nick_name;
        private string correo_electronico;
        private string clave_usuario;
        private string rol;
        private int estado;

        public int Opc { get => opc; set => opc = value; }
        public string Cedula_usuario { get => cedula_usuario; set => cedula_usuario = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Nick_name { get => nick_name; set => nick_name = value; }
        public string Correo_electronico { get => correo_electronico; set => correo_electronico = value; }
        public string Clave_usuario { get => clave_usuario; set => clave_usuario = value; }
        public string Rol { get => rol; set => rol = value; }
        public int Estado { get => estado; set => estado = value; }

        // contructor con parametros 
        public Usuarios(int opc, string cedula_usuario, string nombre_usuario, string apellido1, string apellido2, string nick_name, string correo_electronico, string clave_usuario, string rol, int estado)
        {
            this.opc = opc;
            this.cedula_usuario = cedula_usuario;
            this.nombre_usuario = nombre_usuario;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.nick_name = nick_name;
            this.correo_electronico = correo_electronico;
            this.clave_usuario = clave_usuario;
            this.rol = rol;
            this.estado = estado;
        }
        // constructor sin parametros 
        public Usuarios()
        {
            this.opc = 0;
            this.cedula_usuario = "";
            this.nombre_usuario = "";
            this.apellido1 = "";
            this.apellido2 = "";
            this.nick_name = "";
            this.correo_electronico ="" ;
            this.clave_usuario = "";
            this.rol = "";
            this.estado = 0;
        }
    }
}
