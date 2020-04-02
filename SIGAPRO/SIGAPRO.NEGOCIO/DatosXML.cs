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
        private string numFactura;



        public byte[] Xml { get => xml; set => xml = value; }
        public int Opc { get => opc; set => opc = value; }
        public string NumFactura { get => numFactura; set => numFactura = value; }

        // contructor con parametros.
        public DatosXML(byte[] xml, int opc, string numFactura)
        {
            this.xml = xml;
            this.opc = opc;
            this.numFactura = numFactura;
        }


        //contructor sin parametros
        public DatosXML()
        {
            this.Opc = 0;
            this.Xml = null;
            this.numFactura = "";

        }

      
       
    }
}
