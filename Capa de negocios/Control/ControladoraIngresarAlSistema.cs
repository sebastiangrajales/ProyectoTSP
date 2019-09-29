using Capa_de_negocios.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_negocios.Control
{
    class ControladoraIngresarAlSistema
    {
        public ControladoraIngresarAlSistema()
        {

        }
        public Boolean Ingresar(String codigo,String contraseña)
        {
            if(RepositorioFake.consultarUsuario(codigo,contraseña))
            {
                return true;
            }
            return false;
        }
    }
}
