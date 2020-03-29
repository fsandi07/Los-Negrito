using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGAPRO.NEGOCIO
{
   public class Clasificacion_Factura
    {
        private int opc;
        private string estado_detalle;
        private int id_detalle;
        private string nombre_clasificacion;
        private string descripcion_clasificacion;

        public Clasificacion_Factura(int opc, string estado_detalle, int id_detalle, string nombre_clasificacion, string descripcion_clasificacion)
        {
            this.opc = opc;
            this.estado_detalle = estado_detalle;
            this.id_detalle = id_detalle;
            this.nombre_clasificacion = nombre_clasificacion;
            this.descripcion_clasificacion = descripcion_clasificacion;
        }

        public Clasificacion_Factura()
        {
            this.opc =0;
            this.estado_detalle ="";
            this.id_detalle = 0;
            this.nombre_clasificacion = "";
            this.descripcion_clasificacion = "";
        }

        public int Opc { get => opc; set => opc = value; }
        public string Estado_detalle { get => estado_detalle; set => estado_detalle = value; }
        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public string Nombre_clasificacion { get => nombre_clasificacion; set => nombre_clasificacion = value; }
        public string Descripcion_clasificacion { get => descripcion_clasificacion; set => descripcion_clasificacion = value; }
    }
}
