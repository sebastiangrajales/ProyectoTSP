using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_negocios.Entidades
{
    class Tarea
    {
        public String nombreTarea { get; set; }
        public int minutosLiderEquipo { get; set; }
        public int minutosLiderPlaneacion { get; set; }
        public int minutosLiderSoporte { get; set; }
        public int minutosLiderCalidad { get; set; }
        public int minutosLiderDesarrollo { get; set; }
        public int minutosTotalesPlaneados { get; set; }
        public int semanaPlaneadaTerminacion { get; set; }
        public double valorPlaneado { get; set; }
        private List<String> minutosRolReal;
        private int minutosTotalesReal;
        private int semanaRealTerminacion;
        private int valorGanado;
        public double horasTrabajoSemanal { get; set; }

        public Tarea(String nombreTarea,int minutosLider,int minutosLiderPlaneacion,int minutosLiderSoporte,int minutosLiderCalidad,
            int minutosLiderDesarrollo,int semanaPlaneadaterminacion)
        {
            nombreTarea = this.nombreTarea;
            minutosLiderEquipo=this.minutosLiderEquipo;
            minutosLiderPlaneacion=this.minutosLiderPlaneacion;
            minutosLiderSoporte=this.minutosLiderSoporte;
            minutosLiderCalidad=this.minutosLiderCalidad;
            minutosLiderDesarrollo=this.minutosLiderDesarrollo;
            minutosTotalesPlaneados = minutosLiderCalidad + minutosLiderDesarrollo + minutosLiderEquipo +
                minutosLiderSoporte + minutosLiderPlaneacion;
            valorPlaneado = minutosTotalesPlaneados / horasTrabajoSemanal;

        }

 
    }
}
