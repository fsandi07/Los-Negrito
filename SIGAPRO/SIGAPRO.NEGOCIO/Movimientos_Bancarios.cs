using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
   public class Movimientos_Bancarios
    {
        //estos son para el ingreso del movimiento como tal
        int opc,id_registro_banco;
        string id_banco, detalle_movi, fecha_registro, nombre_movi, moneda;

        //estos para hacer un registro transaccion
        string fecha_movi_regis, detalle_registro, tipo_registro, item, numero;
        float cantidad_dinero, saldo;
        int id_trans_banc;

        public int Opc { get => opc; set => opc = value; }
        public string Id_banco { get => id_banco; set => id_banco = value; }
        public string Detalle_movi { get => detalle_movi; set => detalle_movi = value; }
        public string Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public string Nombre_movi { get => nombre_movi; set => nombre_movi = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public string Fecha_movi_regis { get => fecha_movi_regis; set => fecha_movi_regis = value; }
        public string Detalle_registro { get => detalle_registro; set => detalle_registro = value; }
        public string Tipo_registro { get => tipo_registro; set => tipo_registro = value; }
        public string Item { get => item; set => item = value; }
        public string Numero { get => numero; set => numero = value; }
        public float Cantidad_dinero { get => cantidad_dinero; set => cantidad_dinero = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public int Id_trans_banc { get => id_trans_banc; set => id_trans_banc = value; }
        public int Id_registro_banco { get => id_registro_banco; set => id_registro_banco = value; }

        public Movimientos_Bancarios(int opc, string id_banco, string detalle_movi, string fecha_registro,
            string nombre_movi, string moneda, string fecha_movi_regis, string detalle_registro, string tipo_registro, string item,
            string numero, float cantidad_dinero, float saldo, int id_trans_banc,int id_registro_banco)
        {
            this.opc = opc;
            this.id_banco = id_banco;
            this.detalle_movi = detalle_movi;
            this.fecha_registro = fecha_registro;
            this.nombre_movi = nombre_movi;
            this.moneda = moneda;
            this.fecha_movi_regis = fecha_movi_regis;
            this.detalle_registro = detalle_registro;
            this.tipo_registro = tipo_registro;
            this.item = item;
            this.numero = numero;
            this.cantidad_dinero = cantidad_dinero;
            this.saldo = saldo;
            this.id_trans_banc = id_trans_banc;
            this.id_registro_banco = id_registro_banco;
        }


        public Movimientos_Bancarios()
        {
            this.opc = 0;
            this.id_banco = "";
            this.detalle_movi = "";
            this.fecha_registro = "";
            this.nombre_movi = "";
            this.moneda = "";
            this.fecha_movi_regis = "";
            this.detalle_registro = "";
            this.tipo_registro = "2";
            this.item = "";
            this.numero = "";
            this.cantidad_dinero = 0;
            this.saldo = 0;
            this.id_trans_banc = 0;
            this.id_registro_banco = 0;
        }



    }
}
