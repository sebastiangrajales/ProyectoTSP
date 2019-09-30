using Capa_de_negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_negocios.Control
{
    
    class ControladoraAsignarRol
    {
        public List<String> listaRolesTSP;

        ControladoraAsignarRol() {
            listaRolesTSP = new List<string>();
            listaRolesTSP.Add("LiderDesarrollo");
            listaRolesTSP.Add("LiderCalidad");
            listaRolesTSP.Add("LiderPlaneacion");
            listaRolesTSP.Add("LiderSoporte");
        }

        public Boolean AsignarRolUsuario(Usuario usuario, String rol)
        {
            Boolean seAsignoUsuario = false;
            if (ValidarRol(rol))
            {
                usuario.rol = rol;
                seAsignoUsuario = true;
            }
            return seAsignoUsuario;
        }

        private Boolean ValidarRol(String rol)
        {
            Boolean seValidoRol = false;
            foreach (String iteradorRol in listaRolesTSP)
            {
                if (iteradorRol.Equals(rol))
                {
                    seValidoRol = true;
                }
            }
            return seValidoRol;
        }

    }
}
