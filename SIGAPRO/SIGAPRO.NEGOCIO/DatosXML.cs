using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class DatosXML
    {
        private byte[] xml;
        private int opc;
        private string aceptada_gti, cuenta_por_pagar, factura_fisica, detalle;
        private DateTime vencimiento;
        private byte[] archivo_pdf;

        // contructor con parametros.
        public DatosXML(byte[] xml, int opc, string aceptada_gti, string cuenta_por_pagar, string factura_fisica, string detalle, DateTime vencimiento, byte[] archivo_pdf)
        {
            this.Xml = xml;
            this.Opc = opc;
            this.aceptada_gti = aceptada_gti;
            this.cuenta_por_pagar = cuenta_por_pagar;
            this.factura_fisica = factura_fisica;
            this.detalle = detalle;
            this.vencimiento = vencimiento;
            this.archivo_pdf = archivo_pdf;
        }
        //contructor sin parametros
        public DatosXML()
        {
            this.Opc = 0;
            this.aceptada_gti = "";
            this.cuenta_por_pagar = "";
            this.factura_fisica = "";
            this.detalle = "";
            this.vencimiento = DateTime.Today;
     
        }

        public byte[] Xml { get => xml; set => xml = value; }
        public int Opc { get => opc; set => opc = value; }
        public string Aceptada_gti { get => aceptada_gti; set => aceptada_gti = value; }
        public string Cuenta_por_pagar { get => cuenta_por_pagar; set => cuenta_por_pagar = value; }
        public string Factura_fisica { get => factura_fisica; set => factura_fisica = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public DateTime Vencimiento { get => vencimiento; set => vencimiento = value; }
        public byte[] Archivo_pdf { get => archivo_pdf; set => archivo_pdf = value; }
    }
}
