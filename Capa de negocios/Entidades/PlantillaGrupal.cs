using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_negocios.Entidades
{
    class PlantillaGrupal
    {
        private List<Tarea> tareas;

        public PlantillaGrupal()
        {
            tareas = new List<Tarea>();
        }

        private Tarea buscarTarea(String nombreTarea)
        {
            foreach(Tarea tarea in tareas)
            {
                if (tarea.nombreTarea.Equals(nombreTarea))
                    return tarea;
            }
            return null;
        }

        public void modificarTarea(String datos)
        {

        }

        public void agregarTareas(String datos)
        {
            String nombreTarea="";
            Int32 minutosLiderEquipo=0;
            Int32 minutosLiderPlaneacion=0;
            Int32 minutosLiderCalidad=0;
            Int32 minutosLiderSoporte=0;
            Int32 minutosLiderDesarrollo=0;
            Int32 semanaPlaneadaTerminacion=0;
            String datosDeTareas = "";
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i] == '}')
                {
                    String[] vectorSeparador = datosDeTareas.Split(',');
                    foreach (String tarea in vectorSeparador)
                    {
                        String[] vectorSeparacion;
                        vectorSeparacion = tarea.Split(':');
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
                                minutosLiderCalidad = Convert.ToInt32(vectorSeparacion[1]);
                                return;
                            case "soporte":
                                minutosLiderSoporte = Convert.ToInt32(vectorSeparacion[1]);
                                return;
                            case "desarrollo":
                                minutosLiderDesarrollo = Convert.ToInt32(vectorSeparacion[1]);
                                return;
                            case "semanaTerminacionPlaneada":
                                semanaPlaneadaTerminacion = Convert.ToInt32(vectorSeparacion[1]);
                                return;
                        }
                    }
                    tareas.Add(new Tarea(nombreTarea,minutosLiderEquipo,minutosLiderPlaneacion,minutosLiderCalidad,minutosLiderSoporte,
                        minutosLiderDesarrollo,semanaPlaneadaTerminacion));
                    datosDeTareas = "";
                }
                else if (datos[i] != '{')
                {
                    datosDeTareas += datos[i];
                 
                }
            }
        }
    }
}
