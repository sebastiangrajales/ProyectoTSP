using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_negocios.Entidades;
using Capa_de_negocios.Datos;

namespace Capa_de_negocios.Control
{
    class ControladoraRegistrarAlSistema
    {
        ControladoraRegistrarAlSistema()
        {
           
        }

        public Boolean registrarUsuario(String datos)
        {
            Usuario usuario = new Usuario(datos);
            if (RepositorioFake.BuscarUsuario(usuario.getCodigo()) == null)
            {
                RepositorioFake.adicionarUsuario(usuario);
                return true;
            }
            return false;
        }
    }
}
