using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Moq;

namespace UnitTestProject1
{

    [TestClass]
    public class RecetaServiceIntegracionTest
    {

        [TestMethod]
        public void TestGuardarReceta()
        {
            Receta receta = new Receta();
            IRecetaRepository recetaRepository = new RecetaRepository();
            IRecetaService sut = new RecetaService(recetaRepository);

            sut.Guardar(receta);
        }
        [TestMethod]
        public void TestLeerReceta()
        {
            IRecetaRepository recetaRepository = new RecetaRepository();
            IRecetaService sut = new RecetaService(recetaRepository);

            sut.LeerReceta("Nombre");
                }
        public void TestLeerLista()
        {
            IRecetaRepository recetaRepository = new RecetaRepository();
            IRecetaService sut = new RecetaService(recetaRepository);

            sut.LeerLista();
        }
    }
}
