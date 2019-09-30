using Capa_de_negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_negocios.Control
{
    class ControladoraAsignarLider
    {
        String liderEquipo = "LiderEquipo";

        public Boolean AsignarLider(Usuario usuario)
        {
            usuario.rol = liderEquipo;
            return true;
        }

    }
}
