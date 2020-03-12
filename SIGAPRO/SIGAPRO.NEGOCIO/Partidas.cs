using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Partidas
    {
        private int opc;
        private int numero_partida;
        private string descripcion;
        private string fecha_inicio;
        private string fecha_final;
        private string numero_factura;

        public int Numero_partida { get => numero_partida; set => numero_partida = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public string Fecha_final { get => fecha_final; set => fecha_final = value; }
        public string Numero_factura { get => numero_factura; set => numero_factura = value; }
        public int Opc { get => opc; set => opc = value; }

        public Partidas(int opc, int numero_partida, string descripcion, string fecha_inicio, string fecha_final, string numero_factura)
        {
            this.Opc = opc;
            this.Numero_partida = numero_partida;
            this.Descripcion = descripcion;
            this.Fecha_inicio = fecha_inicio;
            this.Fecha_final = fecha_final;
            this.Numero_factura = numero_factura;
        }
        public Partidas()
        {
            this.Opc = 0;
            this.Numero_partida = 0;
            this.Descripcion = "";
            this.Fecha_inicio = "";
            this.Fecha_final = "";
            this.Numero_factura = "";
        }
    }
}
