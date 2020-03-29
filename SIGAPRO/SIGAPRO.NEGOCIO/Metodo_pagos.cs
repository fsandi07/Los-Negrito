using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Metodo_pagos
    {
        private int opc;
        private int id_metodo;
        private string nombre_metodo;
        private string descripcion_metodo;
        private string num_referencia;
        private string estado;

        public Metodo_pagos(int opc, int id_metodo, string nombre_metodo, string descripcion_metodo, string num_referencia, string estado)
        {
            this.opc = opc;
            this.id_metodo = id_metodo;
            this.nombre_metodo = nombre_metodo;
            this.descripcion_metodo = descripcion_metodo;
            this.num_referencia = num_referencia;
            this.estado = estado;
        }

        public Metodo_pagos()
        {
            this.opc = 0;
            this.id_metodo = 0;
            this.nombre_metodo = "";
            this.descripcion_metodo = "";
            this.num_referencia = "";
            this.estado = "";
        }

        public int Opc { get => opc; set => opc = value; }
        public int Id_metodo { get => id_metodo; set => id_metodo = value; }
        public string Nombre_metodo { get => nombre_metodo; set => nombre_metodo = value; }
        public string Descripcion_metodo { get => descripcion_metodo; set => descripcion_metodo = value; }
        public string Num_referencia { get => num_referencia; set => num_referencia = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
