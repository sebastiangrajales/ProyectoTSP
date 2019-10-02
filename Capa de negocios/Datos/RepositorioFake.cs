using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_negocios.Entidades;

namespace Capa_de_negocios.Datos
{
    public static class RepositorioFake
    {
        static private List<Usuario> usuarios=new List<Usuario>();
        static private List<Tarea> tareas = new List<Tarea>();

        //public RepositorioFake()
        //{
        //  usuarios=new List<Usuario>();
        //}

        public static void adicionarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public static Usuario BuscarUsuario(String codigo)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.getCodigo().Equals(codigo))
                {
                    return usuario;
                }
            }
            return null;
        }

        public static Boolean consultarUsuario(String codigo, String contraseña)
        {
            foreach (Usuario usuario in usuarios)
            {
                if ((usuario.getContraseña().Equals(contraseña)) && (usuario.getCodigo().Equals(codigo)))
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean adicionarTarea(Tarea tarea)
        {

            if (consultarTarea(tarea.nombreTarea)==null)
            {
                tareas.Add(tarea);
                return true;
            }
            return false;

        }

        public static Tarea consultarTarea(String nombreTarea)
        {
            tareas.Add(new Tarea("PrimeraReunion", 120, 120, 120, 120, 120, 4));
            foreach (Tarea iteradorTarea in tareas)
            {
                if (iteradorTarea.nombreTarea.Equals(nombreTarea))
                {
                    return iteradorTarea;
                }
            }
            return null;
        }


    }
}
