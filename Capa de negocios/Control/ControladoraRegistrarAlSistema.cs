using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_negocios.Entidades;
using Capa_de_negocios.Datos;

namespace Capa_de_negocios.Control
{
    public class ControladoraRegistrarAlSistema
    {
        public List<String> roles;
        public ControladoraRegistrarAlSistema()
        {
            roles = new List<string>();
            roles.Add("Coach");
            roles.Add("Estudiante");
        }

        public Boolean registrarUsuario(String datos)
        {
            var nombre="";
            var apellido = "";
            var institucion = "";
            var rol = "";
            var correoElectronico = "";
            var contraseña = "";
            var codigo = "";
            String[] vectorSeparacion;
            vectorSeparacion = datos.Split(',');
            foreach (String datosJSON in vectorSeparacion)
            {
                String[] vectorSeparadorJSON = datosJSON.Split(':');
                switch (vectorSeparadorJSON[0])
                {
                    case "nombre":
                        nombre = vectorSeparadorJSON[1];
                        break;
                    case "apellido":
                        apellido = vectorSeparadorJSON[1];
                        break;
                    case "institucion":
                        institucion = vectorSeparadorJSON[1];
                        break;
                    case "rol":
                        rol = vectorSeparadorJSON[1];
                        break;
                    case "correoElectronico":
                        correoElectronico = vectorSeparadorJSON[1];
                        break;
                    case "contraseña":
                        contraseña = vectorSeparadorJSON[1];
                        break;
                    case "codigo":
                        codigo = vectorSeparadorJSON[1];
                        break;
                }
            }
            foreach (String tipoRol in roles)
            {
                if (rol.Equals(tipoRol))
                {
                    if (RepositorioFake.BuscarUsuario(codigo) == null)
                    {
                        Usuario usuario = new Usuario();
                        usuario.nombre = nombre;
                        usuario.apellido = apellido;
                        usuario.codigo = codigo;
                        usuario.institucion = institucion;
                        usuario.rol = rol;
                        usuario.codigo = codigo;
                        usuario.correoElectronico = correoElectronico;
                        RepositorioFake.adicionarUsuario(usuario);
                        return true;
                    }
                }
            }
            
            return false;
        }
    }
}
