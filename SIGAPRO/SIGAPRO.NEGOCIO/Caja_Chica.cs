using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Caja_Chica
    {
        private int opc, id_Caja,id_movimiento;
        private string nombre_Caja, Descripcion, fecha_inicio,estado,concepto_movimiento, fecha_movimiento, tipo_movimiento;
        private float saldo_inicial, movimiento_dinero, Saldo;

        public int Opc { get => opc; set => opc = value; }
        public int Id_Caja { get => id_Caja; set => id_Caja = value; }
        public int Id_movimiento { get => id_movimiento; set => id_movimiento = value; }
        public string Tipo_movimiento { get => tipo_movimiento; set => tipo_movimiento = value; }
        public string Nombre_Caja { get => nombre_Caja; set => nombre_Caja = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public string Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Concepto_movimiento { get => concepto_movimiento; set => concepto_movimiento = value; }
        public string Fecha_movimiento { get => fecha_movimiento; set => fecha_movimiento = value; }
        public float Saldo_inicial { get => saldo_inicial; set => saldo_inicial = value; }
        public float Movimiento_dinero { get => movimiento_dinero; set => movimiento_dinero = value; }
        public float Saldo1 { get => Saldo; set => Saldo = value; }

        public Caja_Chica(int opc, int id_Caja, int id_movimiento, String tipo_movimiento, string nombre_Caja,
          string descripcion, string fecha_inicio, string estado, string concepto_movimiento, string fecha_movimiento,
          float saldo_inicial, float movimiento_dinero, float saldo)
        {
            this.opc = opc;
            this.id_Caja = id_Caja;
            this.id_movimiento = id_movimiento;
            this.tipo_movimiento = tipo_movimiento;
            this.nombre_Caja = nombre_Caja;
            this.Descripcion = descripcion;
            this.fecha_inicio = fecha_inicio;
            this.estado = estado;
            this.concepto_movimiento = concepto_movimiento;
            this.fecha_movimiento = fecha_movimiento;
            this.saldo_inicial = saldo_inicial;
            this.movimiento_dinero = movimiento_dinero;
            this.Saldo = saldo;
        }

        public Caja_Chica()
        {
            this.opc = 0;
            this.id_Caja = 0;
            this.id_movimiento = 0;
            this.tipo_movimiento = "";
            this.nombre_Caja = "";
            this.Descripcion = "";
            this.fecha_inicio = "";
            this.estado = "";
            this.concepto_movimiento = "";
            this.fecha_movimiento = "";
            this.saldo_inicial = 0;
            this.movimiento_dinero = 0;
            this.Saldo = 0;
        }



    }
}
