using System;
using Capa_de_negocios.Control;
using Capa_de_negocios.Datos;
using Capa_de_negocios.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TestControladoraRegistrarAlSistema
    {
        [TestMethod]
        public void TestRegistrarUsuarioValidoComoEstudiante()
        {
            ControladoraRegistrarAlSistema controladoraRegistrarAlSistema = new ControladoraRegistrarAlSistema();
            
            controladoraRegistrarAlSistema.registrarUsuario("nombre:Cristian,apellido:Agudelo,institucion:Ucaldas," +
                "rol:Estudiante,correo:Electronico:se@f,contraseña:1234,codigo:123");
            Usuario usuario = new Usuario();
            usuario = RepositorioFake.BuscarUsuario("123");
            String nombreEsperado = "Cristian";
            String rolEsperado = "Estudiante";

            String nombreActual = usuario.nombre;
            String rolActual = usuario.rol;

            Assert.AreEqual(nombreEsperado, nombreActual);
            Assert.AreEqual(rolEsperado, rolActual);
        }

        [TestMethod]
        public void TestRegistrarUsuarioValidoComoCoach()
        {
            ControladoraRegistrarAlSistema controladoraRegistrarAlSistema = new ControladoraRegistrarAlSistema();

            controladoraRegistrarAlSistema.registrarUsuario("nombre:Oscar,apellido:Franco,institucion:Ucaldas," +
                "rol:Coach,correo:Electronico:osc@f,contraseña:1234,codigo:222");
            Usuario usuario = new Usuario();
            usuario = RepositorioFake.BuscarUsuario("222");
            String nombreEsperado = "Oscar";
            String rolEsperado = "Coach";

            String nombreActual = usuario.nombre;
            String rolActual = usuario.rol;

            Assert.AreEqual(nombreEsperado, nombreActual);
            Assert.AreEqual(rolEsperado, rolActual);

        }

        [TestMethod]
        public void TestRegistrarUsuarioNoAsignadoABaseDeDatos()
        {
            ControladoraRegistrarAlSistema controladoraRegistrarAlSistema = new ControladoraRegistrarAlSistema();

            controladoraRegistrarAlSistema.registrarUsuario("nombre:Sebastian,apellido:Grajales,institucion:Ucaldas," +
                "rol:LiderDesarrollo,correo:Electronico:osc@f,contraseña:123,codigo:123");
            Usuario usuarioActual = new Usuario();
            usuarioActual = RepositorioFake.BuscarUsuario("456");

            Usuario UsuarioEsperado = null;
            Assert.AreEqual(UsuarioEsperado, usuarioActual);
            
        }

    }
}
