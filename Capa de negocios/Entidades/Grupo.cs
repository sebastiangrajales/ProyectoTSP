using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_negocios.Entidades
{
    class Grupo
    {
        public String nombreDeGrupo { get; set; }
        public String CodigoDecoach { get; set; }
        private List<EquipoDesarrollo> equipos;

        public Grupo()
        {
            equipos = new List<EquipoDesarrollo>();
        }

    }
}
