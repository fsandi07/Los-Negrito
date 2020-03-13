using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Bancos
    {
        private int opc;
        private string nombre_banco, Descripcion, cuenta_iban;

        public int Opc { get => opc; set => opc = value; }
        public string Nombre_banco { get => nombre_banco; set => nombre_banco = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public string Cuenta_iban { get => cuenta_iban; set => cuenta_iban = value; }

        public Bancos(int opc, string nombre_banco, string descripcion, string cuenta_iban)
        {
            this.opc = opc;
            this.nombre_banco = nombre_banco;
            Descripcion = descripcion;
            this.cuenta_iban = cuenta_iban;
        }
        public Bancos()
        {
            this.opc = 0;
            this.nombre_banco = "";
            Descripcion = "";
            this.cuenta_iban = "";
        }
    }
}
