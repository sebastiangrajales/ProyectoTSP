using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_negocios.Entidades
{
    class ListaEquiposDesarrollo
    {
        private static List<EquipoDesarrollo> equipos;
        private static PlantillaGrupal planGrupal;


        public static void adicionarEquipo(EquipoDesarrollo equipo)
        {
            equipos.Add(equipo);
        }

        public static EquipoDesarrollo buscarEquipo(String nombre)
        {
            foreach (EquipoDesarrollo equipo in equipos)
            {
                if (equipo.getNombre().Equals(nombre))
                {
                    return equipo;
                }
            }
            return null;
        }
    }
}
