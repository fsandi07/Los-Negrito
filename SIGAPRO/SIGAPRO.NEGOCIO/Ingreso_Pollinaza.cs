using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Ingreso_Pollinaza
    {
        private int opc, id_ingreso_polli;
        private string id_partida, estado_pago, plazo_pago, numero_factura, nomnbre_cliente, fecha_emision, cantidad_sacos,
                        precio_unidad,total_pago,nombre_pdf,estado;
        private byte[] pdf_comprobante;




        public int Opc { get => opc; set => opc = value; }
        public int Id_ingreso_polli { get => id_ingreso_polli; set => id_ingreso_polli = value; }
        public string Id_partida { get => id_partida; set => id_partida = value; }
        public string Estado_pago { get => estado_pago; set => estado_pago = value; }
        public string Plazo_pago { get => plazo_pago; set => plazo_pago = value; }
        public string Numero_factura { get => numero_factura; set => numero_factura = value; }
        public string Nomnbre_cliente { get => nomnbre_cliente; set => nomnbre_cliente = value; }
        public string Fecha_emision { get => fecha_emision; set => fecha_emision = value; }
        public string Cantidad_sacos { get => cantidad_sacos; set => cantidad_sacos = value; }
        public string Precio_unidad { get => precio_unidad; set => precio_unidad = value; }
        public string Total_pago { get => total_pago; set => total_pago = value; }
        public byte[] Pdf_comprobante { get => pdf_comprobante; set => pdf_comprobante = value; }
        public string Nombre_pdf { get => nombre_pdf; set => nombre_pdf = value; }
        public string Estado { get => estado; set => estado = value; }


        public Ingreso_Pollinaza(int opc, int id_ingreso_polli, string id_partida, string estado_pago, string plazo_pago, string numero_factura,
           string nomnbre_cliente, string fecha_emision, string cantidad_sacos, string precio_unidad, string total_pago, byte[] pdf_comprobante,
           string nombre_pdf, string estado)
        {
            this.opc = opc;
            this.id_ingreso_polli = id_ingreso_polli;
            this.id_partida = id_partida;
            this.estado_pago = estado_pago;
            this.plazo_pago = plazo_pago;
            this.numero_factura = numero_factura;
            this.nomnbre_cliente = nomnbre_cliente;
            this.fecha_emision = fecha_emision;
            this.cantidad_sacos = cantidad_sacos;
            this.precio_unidad = precio_unidad;
            this.total_pago = total_pago;
            this.pdf_comprobante = pdf_comprobante;
            this.nombre_pdf = nombre_pdf;
            this.estado = estado;
        }

        public Ingreso_Pollinaza()
        {
            this.opc = 0;
            this.id_ingreso_polli = 0;
            this.id_partida = "";
            this.estado_pago = "";
            this.plazo_pago = "";
            this.numero_factura = "";
            this.nomnbre_cliente = "";
            this.fecha_emision = "";
            this.cantidad_sacos = "";
            this.precio_unidad = "";
            this.total_pago = "";
            this.pdf_comprobante = null;
            this.nombre_pdf = "";
            this.estado = "";
        }


    }
}
