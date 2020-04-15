using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Control_gasto
    {
        private int id_control,periodo,opc;
        private string id_centro_costos, id_partidas;
        private float total;

        

        public int Id_control { get => id_control; set => id_control = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public string Id_centro_costos { get => id_centro_costos; set => id_centro_costos = value; }
        public string Id_partidas { get => id_partidas; set => id_partidas = value; }
        public float Total { get => total; set => total = value; }
        public int Opc { get => opc; set => opc = value; }

        public Control_gasto(int id_control, int periodo, string id_centro_costos, string id_partidas, float total,int opc)
        {
            this.id_control = id_control;
            this.periodo = periodo;
            this.id_centro_costos = id_centro_costos;
            this.id_partidas = id_partidas;
            this.total = total;
            this.opc = opc;
        }

        public Control_gasto()
        {
            this.id_control = 0;
            this.periodo = 0;
            this.id_centro_costos = "";
            this.id_partidas = "";
            this.total = 0;
            this.opc = 0;
        }


    }
}
