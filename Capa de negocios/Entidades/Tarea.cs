using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_negocios.Entidades
{
    class Tarea
    {
        private String nombreTarea;
        private int minutosLiderEquipo;
        private int minutosLiderPlaneacion;
        private int minutosLiderSoporte;
        private int minutosLiderCalidad;
        private int minutosLiderDesarrollo;
        private int minutosTotalesPlaneados;
        private int semanaPlaneadaTerminacion;
        private int valorPlaneado;
        private List<String> minutosRolReal;
        private int minutosTotalesReal;
        private int semanaRealTerminacion;
        private int valorGanado;

        public Tarea(String datos)
        {
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
                }
            }
        }

        public void setNombre(String nombre)
        {
            nombreTarea = nombre;
        }

        public void setMinutosLiderEquipo(int minutos)
        {
            minutosLiderEquipo = minutos;
        }

        public void setMinutosLiderPlaneacion(int minutos)
        {
            minutosLiderPlaneacion = minutos;
        }

        public void setMinutosLiderSoporte(int minutos)
        {
            minutosLiderSoporte = minutos;
        }

        public void setMinutosLiderCalidad(int minutos)
        {
            minutosLiderCalidad = minutos;
        }

        public void setMinutosLiderDesarrollo(int minutos)
        {
            minutosLiderDesarrollo = minutos;
        }
    }
}
