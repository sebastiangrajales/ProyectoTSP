using Capa_de_negocios.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_negocios.Entidades
{
    public class PlantillaGrupal
    {
        private List<Tarea> tareas;

        public PlantillaGrupal()
        {
        }

        public void agregarTareas(String datos)
        {
            String datosDeTareas = "";
            Tarea nuevaTarea = new Tarea();

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
                                nuevaTarea.nombreTarea = vectorSeparacion[1];
                                return;
                            case "lider":
                                nuevaTarea.minutosLiderEquipo = Convert.ToInt32(vectorSeparacion[1]);
                                return;
                            case "planeacion":
                                nuevaTarea.minutosLiderPlaneacion = Convert.ToInt32(vectorSeparacion[1]);
                                return;
                            case "calidad":
                                nuevaTarea.minutosLiderCalidad = Convert.ToInt32(vectorSeparacion[1]);
                                return;
                            case "soporte":
                                nuevaTarea.minutosLiderSoporte = Convert.ToInt32(vectorSeparacion[1]);
                                return;
                            case "desarrollo":
                                nuevaTarea.minutosLiderDesarrollo = Convert.ToInt32(vectorSeparacion[1]);
                                return;
                            case "semanaTerminacionPlaneada":
                                nuevaTarea.semanaPlaneadaTerminacion = Convert.ToInt32(vectorSeparacion[1]);
                                return;
                        }
                    }
                    RepositorioFake.adicionarTarea(nuevaTarea);
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
