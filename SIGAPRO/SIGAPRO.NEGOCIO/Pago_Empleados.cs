using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Pago_Empleados
    {
        private int opc;
        private int id_comprobante;
        private string mes;
        private string anio;
        private int quincena;
        private string moneda;
        private string fecha_registro;
        private string id_colaborador;
        private string salario_quincenal;
        private string comision;
        private string prestamo;
        private string dias_sinGoce;
        private string total_sinGoce;
        private string dias_feriados;
        private string total_feriados;
        private string horas_extras;
        private string total_extras;
        private string salario_neto;
        private string porcen_caja;
        private string total_caja;
        private string impuesto_renta;
        private string otras_deduc;
        private string detalle_otras_deduc;
        private string total_deduc;
        private string saldo_anterior;
        private string saldo;
        private string total_depositado;
        private string id_banco;
        private string estado;
        private string id_centro_costos;
        private byte[] pdf_comprobante;
        private string realname_pdf;


        public int Opc { get => opc; set => opc = value; }
        public int Id_comprobante { get => id_comprobante; set => id_comprobante = value; }
        public string Mes { get => mes; set => mes = value; }
        public string Anio { get => anio; set => anio = value; }
        public int Quincena { get => quincena; set => quincena = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public string Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public string Id_colaborador { get => id_colaborador; set => id_colaborador = value; }
        public string Salario_quincenal { get => salario_quincenal; set => salario_quincenal = value; }
        public string Comision { get => comision; set => comision = value; }
        public string Prestamo { get => prestamo; set => prestamo = value; }
        public string Dias_sinGoce { get => dias_sinGoce; set => dias_sinGoce = value; }
        public string Total_sinGoce { get => total_sinGoce; set => total_sinGoce = value; }
        public string Dias_feriados { get => dias_feriados; set => dias_feriados = value; }
        public string Total_feriados { get => total_feriados; set => total_feriados = value; }
        public string Horas_extras { get => horas_extras; set => horas_extras = value; }
        public string Total_extras { get => total_extras; set => total_extras = value; }
        public string Salario_neto { get => salario_neto; set => salario_neto = value; }
        public string Porcen_caja { get => porcen_caja; set => porcen_caja = value; }
        public string Impuesto_renta { get => impuesto_renta; set => impuesto_renta = value; }
        public string Otras_deduc { get => otras_deduc; set => otras_deduc = value; }
        public string Detalle_otras_deduc { get => detalle_otras_deduc; set => detalle_otras_deduc = value; }
        public string Total_deduc { get => total_deduc; set => total_deduc = value; }
        public string Saldo_anterior { get => saldo_anterior; set => saldo_anterior = value; }
        public string Saldo { get => saldo; set => saldo = value; }
        public string Total_depositado { get => total_depositado; set => total_depositado = value; }
        public string Id_banco { get => id_banco; set => id_banco = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Id_centro_costos { get => id_centro_costos; set => id_centro_costos = value; }
        public byte[] Pdf_comprobante { get => pdf_comprobante; set => pdf_comprobante = value; }
        public string Total_caja { get => total_caja; set => total_caja = value; }
        public string Realname_pdf { get => realname_pdf; set => realname_pdf = value; }

        public Pago_Empleados(int opc, int id_comprobante, string mes, string anio, int quincena, string moneda,
           string fecha_registro, string id_colaborador, string salario_quincenal, string comision, string prestamo,
           string dias_sinGoce, string total_sinGoce, string dias_feriados, string total_feriados, string horas_extras,
           string total_extras, string salario_neto, string porcen_caja, string impuesto_renta, string otras_deduc,
           string detalle_otras_deduc, string total_deduc, string saldo_anterior, string saldo, string total_depositado,
           string id_banco, string estado, string id_centro_costos, byte[] pdf_comprobante, string total_caja, string realname_pdf)
        {
            this.opc = opc;
            this.id_comprobante = id_comprobante;
            this.mes = mes;
            this.anio = anio;
            this.quincena = quincena;
            this.moneda = moneda;
            this.fecha_registro = fecha_registro;
            this.id_colaborador = id_colaborador;
            this.salario_quincenal = salario_quincenal;
            this.comision = comision;
            this.prestamo = prestamo;
            this.dias_sinGoce = dias_sinGoce;
            this.total_sinGoce = total_sinGoce;
            this.dias_feriados = dias_feriados;
            this.total_feriados = total_feriados;
            this.horas_extras = horas_extras;
            this.total_extras = total_extras;
            this.salario_neto = salario_neto;
            this.porcen_caja = porcen_caja;
            this.impuesto_renta = impuesto_renta;
            this.otras_deduc = otras_deduc;
            this.detalle_otras_deduc = detalle_otras_deduc;
            this.total_deduc = total_deduc;
            this.saldo_anterior = saldo_anterior;
            this.saldo = saldo;
            this.total_depositado = total_depositado;
            this.id_banco = id_banco;
            this.estado = estado;
            this.id_centro_costos = id_centro_costos;
            this.pdf_comprobante = pdf_comprobante;
            this.total_caja = total_caja;
            this.realname_pdf = realname_pdf;
        }
        public Pago_Empleados()
        {
            this.opc = 0;
            this.id_comprobante = 0;
            this.mes = "";
            this.anio = "";
            this.quincena = 0;
            this.moneda = "";
            this.fecha_registro = "";
            this.id_colaborador = "";
            this.salario_quincenal = "";
            this.comision = "";
            this.prestamo = "";
            this.dias_sinGoce = "";
            this.total_sinGoce = "";
            this.dias_feriados = "";
            this.total_feriados = "";
            this.horas_extras = "";
            this.total_extras = "";
            this.salario_neto = "";
            this.porcen_caja = "";
            this.impuesto_renta = "";
            this.otras_deduc = "";
            this.detalle_otras_deduc = "";
            this.total_deduc = "";
            this.saldo_anterior = "";
            this.saldo = "";
            this.total_depositado = "";
            this.id_banco = "";
            this.estado = "";
            this.id_centro_costos = "";
            this.pdf_comprobante = null;
            this.total_caja = "";
            this.realname_pdf = "";
        }

       
    }
}
