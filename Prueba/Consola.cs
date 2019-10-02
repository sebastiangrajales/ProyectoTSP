using Capa_de_negocios.Control;
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
            //ControladoraRegistrarAlSistema controladoraRegistrarAlSistema = new ControladoraRegistrarAlSistema();
            //controladoraRegistrarAlSistema.registrarUsuario("nombre:sebas,apellido:graja,institucion:uca,rol:Coach,correo:Electronico:se@f,contraseña:1234,codigo:12");

            //while (true)
            //{
            //    Console.WriteLine((RepositorioFake.BuscarUsuario("12")).rol);
            //}

            PlantillaGrupal plantillaGrupal = new PlantillaGrupal();

            //
            //RepositorioFake.adicionarTarea(new Tarea("ReunionSemanal",120,120,120,120,120,4));
            plantillaGrupal.agregarTareas("nombre:\"hola\",lider:120,planeacion:120,calidad:120,soporte:120," +
                "desarrollo:120,semanaTerminacionPlaneada:4}");

            while (true)
            {
                Console.WriteLine((RepositorioFake.consultarTarea("ReunionSemanal")).nombreTarea);
            }


        }
    }
}
