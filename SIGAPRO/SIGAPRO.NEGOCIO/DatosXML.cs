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
        // contructor con parametros.
        public DatosXML(byte[] xml,int opc)
        {
            this.Xml = xml;
            this.Opc = opc;
        }
        //contructor sin parametros
        public DatosXML()
        {
            this.Opc = 0;
        }

        public byte[] Xml { get => xml; set => xml = value; }
        public int Opc { get => opc; set => opc = value; }
    }
}
