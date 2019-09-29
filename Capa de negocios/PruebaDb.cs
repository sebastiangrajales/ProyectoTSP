using Capa_de_negocios.Entidades;
using System;
using System.Data.Entity;

namespace Capa_de_negocios
{
    public class PruebaDb
    {
         public PruebaDb()
        {
            Database.SetInitializer<DataContext>(new DropCreateDatabaseAlways<DataContext>());
            Console.WriteLine();
            DataContext dbContext = new DataContext();
            Usuario usuario = new Usuario("nombre:sebas,apellido:graja,institucion:uca,rol:n" +
                ",correo:Electronico:se@f,contraseña:1234,codigo:12");
            dbContext.Usuarios.Add(usuario);
            dbContext.SaveChanges();
            Console.ReadLine();
        }
    }
}
