using Capa_de_negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Capa_de_negocios
{
    public class DataContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
