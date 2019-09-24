using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_negocios.Entidades;

namespace Capa_de_negocios
{
    class ControlCreacionPlantilla
    {
        public Boolean creacionPlantillaGrupal(String datos)
        {
            int i = 0;
            String nombreEquipo = "";
            while (datos[i] != ',')
            {
                nombreEquipo += datos[i];
                i++;
            }
            String json = datos.Substring(i, datos.Length);
            String[] separadorNombre = nombreEquipo.Split(':');
            try
            {

                EquipoDesarrollo equipo = ListaEquiposDesarrollo.buscarEquipo(separadorNombre[0]);
                equipo.crearPlanGrupal(json);
                PlantillaGrupal planGrupal = new PlantillaGrupal();
                planGrupal.agregarTareas(datos);

                return true;
            }
            catch
            {
                return false;
            }


        }
    }
}
