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
        private string id_centro_costos, id_partidas,num_factura;
        private float total;


        public int Id_control { get => id_control; set => id_control = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public int Opc { get => opc; set => opc = value; }
        public string Id_centro_costos { get => id_centro_costos; set => id_centro_costos = value; }
        public string Id_partidas { get => id_partidas; set => id_partidas = value; }
        public string Num_factura { get => num_factura; set => num_factura = value; }
        public float Total { get => total; set => total = value; }


        public Control_gasto(int id_control, int periodo, int opc, string id_centro_costos, string id_partidas, string num_factura, float total)
        {
            this.Id_control = id_control;
            this.Periodo = periodo;
            this.Opc = opc;
            this.Id_centro_costos = id_centro_costos;
            this.Id_partidas = id_partidas;
            this.Num_factura = num_factura;
            this.Total = total;
        }



        public Control_gasto()
        {
            this.Id_control = 0;
            this.Periodo = 0;
            this.Opc = 0;
            this.Id_centro_costos = "";
            this.Id_partidas = "";
            this.Num_factura = "";
            this.Total = 0;
        }



    }
}
