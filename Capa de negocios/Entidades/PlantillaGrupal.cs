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
            return null;
        }

        public void modificarTarea(String datos)
        {

        }

        public void agregarTareas(String datos)
        {
            String datosDeTareas = "";
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i] == '}')
                {
                    tareas.Add(new Tarea(datosDeTareas));
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
