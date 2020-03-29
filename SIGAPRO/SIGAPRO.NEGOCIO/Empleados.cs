using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Empleados
    {
        private int opc;
        private string cedula_empleado;
        private string nombre_empelado;
        private string apellido1_empleado;
        private string apellido2_empleado;
        private string domicilio;
        private string telefono_empleado;
        private string correo_empleado;
        private string cuenta_banco_empleado;
        private string fecha_nacimientoi_empleado;
        private string fecha_inicio_empleado;
        private string estado_empleado;

      

        public int Opc { get => opc; set => opc = value; }
        public string Cedula_empleado { get => cedula_empleado; set => cedula_empleado = value; }
        public string Nombre_empelado { get => nombre_empelado; set => nombre_empelado = value; }
        public string Apellido1_empleado { get => apellido1_empleado; set => apellido1_empleado = value; }
        public string Apellido2_empleado { get => apellido2_empleado; set => apellido2_empleado = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Telefono_empleado { get => telefono_empleado; set => telefono_empleado = value; }
        public string Correo_empleado { get => correo_empleado; set => correo_empleado = value; }
        public string Cuenta_banco_empleado { get => cuenta_banco_empleado; set => cuenta_banco_empleado = value; }
        public string Fecha_nacimientoi_empleado { get => fecha_nacimientoi_empleado; set => fecha_nacimientoi_empleado = value; }
        public string Fecha_inicio_empleado { get => fecha_inicio_empleado; set => fecha_inicio_empleado = value; }
        public string Estado_empleado { get => estado_empleado; set => estado_empleado = value; }

        public Empleados(int opc, string cedula_empleado, string nombre_empelado, string apellido1_empleado,
         string apellido2_empleado, string domicilio, string telefono_empleado, string correo_empleado,
         string cuenta_banco_empleado, string fecha_nacimientoi_empleado, string fecha_inicio_empleado, string estado_empleado)
        {
            this.opc = opc;
            this.cedula_empleado = cedula_empleado;
            this.nombre_empelado = nombre_empelado;
            this.apellido1_empleado = apellido1_empleado;
            this.apellido2_empleado = apellido2_empleado;
            this.domicilio = domicilio;
            this.telefono_empleado = telefono_empleado;
            this.correo_empleado = correo_empleado;
            this.cuenta_banco_empleado = cuenta_banco_empleado;
            this.fecha_nacimientoi_empleado = fecha_nacimientoi_empleado;
            this.fecha_inicio_empleado = fecha_inicio_empleado;
            this.estado_empleado = estado_empleado;
        }

        public Empleados()
        {
            this.opc = 0;
            this.cedula_empleado = "";
            this.nombre_empelado = "";
            this.apellido1_empleado = "";
            this.apellido2_empleado = "";
            this.domicilio = "";
            this.telefono_empleado = "";
            this.correo_empleado = "";
            this.cuenta_banco_empleado = "";
            this.fecha_nacimientoi_empleado = "";
            this.fecha_inicio_empleado = "";
            this.estado_empleado = "";
        }

      
    }

   


}
