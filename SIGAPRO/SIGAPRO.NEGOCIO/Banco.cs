using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Banco
    {
        private int opc,id_banco;
        private string nombre_banco, Descripcion, cuenta_iban,estado;

     
         public Banco()
        {
            this.opc = 0;
            this.nombre_banco = "";
            Descripcion = "";
            this.cuenta_iban = "";
            this.estado = "";
            this.id_banco = 0;


        }

        public Banco(int opc, int id_banco, string nombre_banco, string descripcion, string cuenta_iban, string estado)
        {
            this.opc = opc;
            this.id_banco = id_banco;
            this.nombre_banco = nombre_banco;
            Descripcion = descripcion;
            this.cuenta_iban = cuenta_iban;
            this.estado = estado;
        }

        public int Opc { get => opc; set => opc = value; }
        public string Nombre_banco { get => nombre_banco; set => nombre_banco = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public string Cuenta_iban { get => cuenta_iban; set => cuenta_iban = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Id_banco { get => id_banco; set => id_banco = value; }
    }
}
