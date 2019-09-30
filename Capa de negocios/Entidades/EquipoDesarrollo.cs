using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_negocios.Entidades
{
    class EquipoDesarrollo
    {
        private String nombreEquipo;
        private List<Usuario> listaUsuarios;
        private PlantillaGrupal plangrupal;

        public EquipoDesarrollo(String datos)
        {
            listaUsuarios = new List<Usuario>();
            nombreEquipo = datos;
        }

        public String getNombre()
        {
            return nombreEquipo;
        }

        public Usuario buscarIntegrante(String nombreUsuario)
        {
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.getNombre().Equals(nombreUsuario))
                {
                    return usuario;
                }
            }
            return null;
        }

        public Boolean crearPlanGrupal(String datos)
        {
            try
            {
                plangrupal = new PlantillaGrupal();
                plangrupal.agregarTareas(datos);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
