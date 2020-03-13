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
        private string numero_fatura;

        public int Opc { get => opc; set => opc = value; }
        public string Numero_centro_costos { get => numero_centro_costos; set => numero_centro_costos = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Numero_fatura { get => numero_fatura; set => numero_fatura = value; }

        public centro_de_costos(int opc, string numero_centro_costos, string descripcion, string numero_fatura)
        {
            this.opc = opc;
            this.numero_centro_costos = numero_centro_costos;
            this.descripcion = descripcion;
            this.numero_fatura = numero_fatura;
        }
        public centro_de_costos()
        {
            this.opc = 0;
            this.numero_centro_costos = "";
            this.descripcion = "";
            this.numero_fatura = "";
        }
    }
}
