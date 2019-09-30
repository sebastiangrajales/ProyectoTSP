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

        public Tarea(String datos)
        {
            minutosLiderEquipo=0;
            minutosLiderPlaneacion=0;
            minutosLiderSoporte=0;
            minutosLiderCalidad=0;
            minutosLiderDesarrollo=0;
        String[] vectorSeparador = datos.Split(',');
            foreach (String dato in vectorSeparador)
            {
                String[] vectorSeparacion;
                vectorSeparacion = dato.Split(':');
                switch (vectorSeparacion[0])
                {
                    case "nombre":
                        nombreTarea = vectorSeparacion[1];
                        return;
                    case "lider":
                        minutosLiderEquipo = Convert.ToInt32(vectorSeparacion[1]);
                        return;
                    case "planeacion":
                        minutosLiderPlaneacion = Convert.ToInt32(vectorSeparacion[1]);
                        return;
                    case "calidad":
                        minutosLiderPlaneacion = Convert.ToInt32(vectorSeparacion[1]);
                        return;
                    case "soporte":
                        minutosLiderPlaneacion = Convert.ToInt32(vectorSeparacion[1]);
                        return;
                    case "desarrollo":
                        minutosLiderPlaneacion = Convert.ToInt32(vectorSeparacion[1]);
                        return;
                    case "semanaTerminacionPlaneada":
                        semanaPlaneadaTerminacion= Convert.ToInt32(vectorSeparacion[1]);
                        return;
            
                }
            }
            minutosTotalesPlaneados = minutosLiderCalidad + minutosLiderDesarrollo + minutosLiderEquipo +
                minutosLiderSoporte + minutosLiderPlaneacion;
            valorPlaneado = minutosTotalesPlaneados / horasTrabajoSemanal;

        }

 
    }
}
