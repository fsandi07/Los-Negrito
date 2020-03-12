using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
    public class Pagos_empleados
    {
        private int opc;
        private string cedula_empleado;
        private float salario_quincenal;
        private float prestamo;
        private string banco;
        private string moneda;
        private int quincena;
        private string mes_a_pagar;
        private int dias_sin_goce;
        private float perdido_dias_sin_goce;
        private float comision_productividad;
        private float ganado_feriados;
        private int dias_feriados;
        private float ganado_extras;
        private int horas_extras;
        private float salario_neto;
        private float caja_seguro;
        private float impuesto_renta;
        private float otras_deducciones;
        private string descri_otras_deducc;
        private float total_deducciones;
        private float total_depositado;
        private float total_anterior;
        private float saldo;
        private int boleta_entregada;

        public int Opc { get => opc; set => opc = value; }
        public string Cedula_empleado { get => cedula_empleado; set => cedula_empleado = value; }
        public float Salario_quincenal { get => salario_quincenal; set => salario_quincenal = value; }
        public float Prestamo { get => prestamo; set => prestamo = value; }
        public string Banco { get => banco; set => banco = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public int Quincena { get => quincena; set => quincena = value; }
        public string Mes_a_pagar { get => mes_a_pagar; set => mes_a_pagar = value; }
        public int Dias_sin_goce { get => dias_sin_goce; set => dias_sin_goce = value; }
        public float Perdido_dias_sin_goce { get => perdido_dias_sin_goce; set => perdido_dias_sin_goce = value; }
        public float Comision_productividad { get => comision_productividad; set => comision_productividad = value; }
        public float Ganado_feriados { get => ganado_feriados; set => ganado_feriados = value; }
        public int Dias_feriados { get => dias_feriados; set => dias_feriados = value; }
        public float Ganado_extras { get => ganado_extras; set => ganado_extras = value; }
        public int Horas_extras { get => horas_extras; set => horas_extras = value; }
        public float Salario_neto { get => salario_neto; set => salario_neto = value; }
        public float Caja_seguro { get => caja_seguro; set => caja_seguro = value; }
        public float Impuesto_renta { get => impuesto_renta; set => impuesto_renta = value; }
        public float Otras_deducciones { get => otras_deducciones; set => otras_deducciones = value; }
        public string Descri_otras_deducc { get => descri_otras_deducc; set => descri_otras_deducc = value; }
        public float Total_deducciones { get => total_deducciones; set => total_deducciones = value; }
        public float Total_depositado { get => total_depositado; set => total_depositado = value; }
        public float Total_anterior { get => total_anterior; set => total_anterior = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public int Boleta_entregada { get => boleta_entregada; set => boleta_entregada = value; }

        public Pagos_empleados(int opc, string cedula_empleado, float salario_quincenal, float prestamo, string banco,
            string moneda, int quincena, string mes_a_pagar, int dias_sin_goce, float perdido_dias_sin_goce, float comision_productividad,
            float ganado_feriados, int dias_feriados, float ganado_extras, int horas_extras, float salario_neto,
            float caja_seguro, float impuesto_renta, float otras_deducciones, string descri_otras_deducc,
            float total_deducciones, float total_depositado, float total_anterior, float saldo, int boleta_entregada)
        {
            this.opc = opc;
            this.cedula_empleado = cedula_empleado;
            this.salario_quincenal = salario_quincenal;
            this.prestamo = prestamo;
            this.banco = banco;
            this.moneda = moneda;
            this.quincena = quincena;
            this.mes_a_pagar = mes_a_pagar;
            this.dias_sin_goce = dias_sin_goce;
            this.perdido_dias_sin_goce = perdido_dias_sin_goce;
            this.comision_productividad = comision_productividad;
            this.ganado_feriados = ganado_feriados;
            this.dias_feriados = dias_feriados;
            this.ganado_extras = ganado_extras;
            this.horas_extras = horas_extras;
            this.salario_neto = salario_neto;
            this.caja_seguro = caja_seguro;
            this.impuesto_renta = impuesto_renta;
            this.otras_deducciones = otras_deducciones;
            this.descri_otras_deducc = descri_otras_deducc;
            this.total_deducciones = total_deducciones;
            this.total_depositado = total_depositado;
            this.total_anterior = total_anterior;
            this.saldo = saldo;
            this.boleta_entregada = boleta_entregada;
        }

        public Pagos_empleados()
        {
            this.opc = 0;
            this.cedula_empleado = "";
            this.salario_quincenal = 0;
            this.prestamo = 0;
            this.banco = "";
            this.moneda = "";
            this.quincena = 0;
            this.mes_a_pagar = "";
            this.dias_sin_goce = 0;
            this.perdido_dias_sin_goce = 0;
            this.comision_productividad = 0;
            this.ganado_feriados = 0;
            this.dias_feriados = 0;
            this.ganado_extras = 0;
            this.horas_extras = 0;
            this.salario_neto = 0;
            this.caja_seguro = 0;
            this.impuesto_renta = 0;
            this.otras_deducciones = 0;
            this.descri_otras_deducc = "";
            this.total_deducciones = 0;
            this.total_depositado = 0;
            this.total_anterior = 0;
            this.saldo = 0;
            this.boleta_entregada = 0;
        }




    }
}
