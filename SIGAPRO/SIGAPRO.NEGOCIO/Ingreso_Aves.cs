using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Ingreso_Aves
    {
        private int id_ingreso_aves,opc;
        private string  id_partida, estado_pago, plazo_pago, numero_factura,nombre_comercio,
                        fecha_emision, monto_factura, detalle_factura, monto_otra_carga, detalle_otra_carga,
                        porcent_iva, total_iva, total_menos_iva, total_menos_otros_iva,estado,nombre_pdf;
        private byte[] pdf_comprobante;

        public int Id_ingreso_aves { get => id_ingreso_aves; set => id_ingreso_aves = value; }
        public int Opc { get => opc; set => opc = value; }
        public string Id_partida { get => id_partida; set => id_partida = value; }
        public string Estado_pago { get => estado_pago; set => estado_pago = value; }
        public string Plazo_pago { get => plazo_pago; set => plazo_pago = value; }
        public string Numero_factura { get => numero_factura; set => numero_factura= value; }
        public string Fecha_emision { get => fecha_emision; set => fecha_emision = value; }
        public string Monto_factura { get => monto_factura; set => monto_factura = value; }
        public string Detalle_factura { get => detalle_factura; set => detalle_factura = value; }
        public string Monto_otra_carga { get => monto_otra_carga; set => monto_otra_carga = value; }
        public string Detalle_otra_carga { get => detalle_otra_carga; set => detalle_otra_carga = value; }
        public string Porcent_iva { get => porcent_iva; set => porcent_iva = value; }
        public string Total_iva { get => total_iva; set => total_iva = value; }
        public string Total_menos_iva { get => total_menos_iva; set => total_menos_iva = value; }
        public string Total_menos_otros_iva { get => total_menos_otros_iva; set => total_menos_otros_iva = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Nombre_pdf { get => nombre_pdf; set => nombre_pdf = value; }
        public byte[] Pdf_comprobante { get => pdf_comprobante; set => pdf_comprobante = value; }
        public string Nombre_comercio { get => nombre_comercio; set => nombre_comercio = value; }

        public Ingreso_Aves(int id_ingreso_aves, int opc, string id_partida, string estado_pago, string plazo_pago, 
            string numero_factura, string fecha_emision, string monto_factura, string detalle_factura, 
            string monto_otra_carga, string detalle_otra_carga, string porcent_iva, string total_iva, string total_menos_iva, 
            string total_menos_otros_iva, string estado, string nombre_pdf, byte[] pdf_comprobante, string nombre_comercio)
        {
            this.id_ingreso_aves = id_ingreso_aves;
            this.opc = opc;
            this.id_partida = id_partida;
            this.estado_pago = estado_pago;
            this.plazo_pago = plazo_pago;
            this.numero_factura = numero_factura;
            this.fecha_emision = fecha_emision;
            this.monto_factura = monto_factura;
            this.detalle_factura = detalle_factura;
            this.monto_otra_carga = monto_otra_carga;
            this.detalle_otra_carga = detalle_otra_carga;
            this.porcent_iva = porcent_iva;
            this.total_iva = total_iva;
            this.total_menos_iva = total_menos_iva;
            this.total_menos_otros_iva = total_menos_otros_iva;
            this.estado = estado;
            this.nombre_pdf = nombre_pdf;
            this.pdf_comprobante = pdf_comprobante;
            this.nombre_comercio = nombre_comercio;
        }
        public Ingreso_Aves()
        {
            this.id_ingreso_aves = 0;
            this.opc = 0;
            this.id_partida = "";
            this.estado_pago = "";
            this.plazo_pago = "";
            this.numero_factura ="" ;
            this.fecha_emision = "";
            this.monto_factura = "";
            this.detalle_factura = "";
            this.monto_otra_carga = "";
            this.detalle_otra_carga = "";
            this.porcent_iva = "";
            this.total_iva = "";
            this.total_menos_iva = "";
            this.total_menos_otros_iva = "";
            this.estado = "";
            this.nombre_pdf = "";
            this.pdf_comprobante = null;
            this.nombre_comercio = "";
        }

       
    }
}
