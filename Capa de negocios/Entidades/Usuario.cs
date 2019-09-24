using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_negocios.Entidades
{
    class Usuario
    {
        private String nombre;
        private String apellido;
        private String institucion;
        private String rol;
        private String correoElectronico;
        private String contraseña;
        private String codigo;

        public Usuario(String datos)
        {
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
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getCodigo()
        {
            return codigo;
        }

        public String getCorreoElectronico()
        {
            return correoElectronico;
        }

        public String getContraseña()
        {
            return contraseña;
        }
    }
}
