using Capa_de_negocios;
using Capa_de_negocios.Datos;
using Capa_de_negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Consola
    {
        static void Main(string[] args)
        {
            //var prueba = new PruebaDb();
            Usuario usuario = new Usuario("nombre:sebas,apellido:graja,institucion:uca,rol:n" +
                ",correo:Electronico:se@f,contraseña:1234,codigo:12");
            RepositorioFake.adicionarUsuario(usuario);
            Console.WriteLine((RepositorioFake.BuscarUsuario("12")).getNombre());
        }
    }
}
