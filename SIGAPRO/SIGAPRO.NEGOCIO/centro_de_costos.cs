using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class centro_de_costos
    {
        private int opc;       
        private string numero_centro_costos;
        private string descripcion;
        private string estado;

        public int Opc { get => opc; set => opc = value; }
        public string Numero_centro_costos { get => numero_centro_costos; set => numero_centro_costos = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Estado { get => estado; set => estado = value; }

        public centro_de_costos(int opc, string numero_centro_costos, string descripcion, string estado)
        {
            this.Opc = opc;
            this.Numero_centro_costos = numero_centro_costos;
            this.Descripcion = descripcion;
            this.estado = estado;
        }

        public centro_de_costos()
        {
            this.Opc = 0;
            this.Numero_centro_costos = "";
            this.Descripcion = "";
            this.estado = "";
        }

       
    }
}
