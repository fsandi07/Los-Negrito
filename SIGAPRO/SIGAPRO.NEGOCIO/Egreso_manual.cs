using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
   public class Egreso_manual
    {
        private int opc, id_egreso;
        private string digital, fecha_registro, numero_factura, fisica, gti, nombre_comercio, id_detalle, id_partida, monto_factura,
                        estado_pago, plazo_pago, nombre_pdf, id_centroCostos, estado, id_banco, id_metodo_pago,moneda,porcenIva,totalIva,
                        cedula_juridica,tipo_cambio,mes;
        private byte[] pdf_factura;

        public int Opc { get => opc; set => opc = value; }
        public int Id_egreso { get => id_egreso; set => id_egreso = value; }
        public string Digital { get => digital; set => digital = value; }
        public string Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public string Numero_factura { get => numero_factura; set => numero_factura = value; }
        public string Fisica { get => fisica; set => fisica = value; }
        public string Gti { get => gti; set => gti = value; }
        public string Nombre_comercio { get => nombre_comercio; set => nombre_comercio = value; }
        public string Id_detalle { get => id_detalle; set => id_detalle = value; }
        public string Id_partida { get => id_partida; set => id_partida = value; }
        public string Monto_factura { get => monto_factura; set => monto_factura = value; }
        public string Estado_pago { get => estado_pago; set => estado_pago = value; }
        public string Plazo_pago { get => plazo_pago; set => plazo_pago = value; }
        public string Nombre_pdf { get => nombre_pdf; set => nombre_pdf = value; }
        public string Id_centroCostos { get => id_centroCostos; set => id_centroCostos = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Id_banco { get => id_banco; set => id_banco = value; }
        public string Id_metodo_pago { get => id_metodo_pago; set => id_metodo_pago = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public string PorcenIva { get => porcenIva; set => porcenIva = value; }
        public string TotalIva { get => totalIva; set => totalIva = value; }
        public byte[] Pdf_factura { get => pdf_factura; set => pdf_factura = value; }
        public string Cedula_juridica { get => cedula_juridica; set => cedula_juridica = value; }
        public string Tipo_cambio { get => tipo_cambio; set => tipo_cambio = value; }
        public string Mes { get => mes; set => mes = value; }

        public Egreso_manual()
        {
            this.opc = 0;
            this.id_egreso = 0;
            this.digital = "";
            this.fecha_registro = "";
            this.numero_factura = "";
            this.fisica = "";
            this.gti = "";
            this.nombre_comercio = "";
            this.id_detalle = "";
            this.id_partida = "";
            this.monto_factura = "";
            this.estado_pago = "";
            this.plazo_pago = "";
            this.nombre_pdf = "";
            this.id_centroCostos = "";
            this.estado = "";
            this.pdf_factura =null ;
            this.id_banco = "";
            this.id_metodo_pago = "";
            this.porcenIva = "";
            this.totalIva = "";
            this.moneda = "";
            this.cedula_juridica = "";
            this.tipo_cambio = "";
            this.mes = "";
        }

        public Egreso_manual(int opc, int id_egreso, string digital, string fecha_registro, string numero_factura, string fisica, 
            string gti, string nombre_comercio, string id_detalle, string id_partida, string monto_factura, string estado_pago,
            string plazo_pago, string nombre_pdf, string id_centroCostos, string estado, string id_banco, string id_metodo_pago, 
            string moneda, string porcenIva, string totalIva, string cedula_juridica, string tipo_cambio, string mes, byte[] pdf_factura)
        {
            this.opc = opc;
            this.id_egreso = id_egreso;
            this.digital = digital;
            this.fecha_registro = fecha_registro;
            this.numero_factura = numero_factura;
            this.fisica = fisica;
            this.gti = gti;
            this.nombre_comercio = nombre_comercio;
            this.id_detalle = id_detalle;
            this.id_partida = id_partida;
            this.monto_factura = monto_factura;
            this.estado_pago = estado_pago;
            this.plazo_pago = plazo_pago;
            this.nombre_pdf = nombre_pdf;
            this.id_centroCostos = id_centroCostos;
            this.estado = estado;
            this.id_banco = id_banco;
            this.id_metodo_pago = id_metodo_pago;
            this.moneda = moneda;
            this.porcenIva = porcenIva;
            this.totalIva = totalIva;
            this.cedula_juridica = cedula_juridica;
            this.tipo_cambio = tipo_cambio;
            this.mes = mes;
            this.pdf_factura = pdf_factura;
        }
    }
}
