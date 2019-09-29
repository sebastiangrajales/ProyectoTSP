using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_negocios.Entidades
{
    public class Usuario
    {
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String institucion { get; set; }
        public String rol { get; set; }
        public String correoElectronico { get; set; }
        public String contraseña { get; set; }
        [Key]
        public String codigo { get; set; }
        

        public Usuario()
        {
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
