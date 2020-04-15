using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Partida
    {
        private int opc,perido;
        private string numero_partida;
        private string descripcion;
        private string fecha_inicio;
        private string fecha_final;
        private string numero_factura;
        private string estado;

        public string Numero_partida { get => numero_partida; set => numero_partida = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public string Fecha_final { get => fecha_final; set => fecha_final = value; }
        public string Numero_factura { get => numero_factura; set => numero_factura = value; }
        public int Opc { get => opc; set => opc = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Perido { get => perido; set => perido = value; }

        public Partida(int opc, int perido, string numero_partida, string descripcion, string fecha_inicio, string fecha_final, string numero_factura, string estado)
        {
            this.opc = opc;
            this.perido = perido;
            this.numero_partida = numero_partida;
            this.descripcion = descripcion;
            this.fecha_inicio = fecha_inicio;
            this.fecha_final = fecha_final;
            this.numero_factura = numero_factura;
            this.estado = estado;
        }


        public Partida()
        {
            this.Opc = 0;
            this.Numero_partida = "";
            this.Descripcion = "";
            this.Fecha_inicio = "";
            this.Fecha_final = "";
            this.Numero_factura = "";
            this.estado = "";
            this.perido = 0;

        }

    
    }
}
