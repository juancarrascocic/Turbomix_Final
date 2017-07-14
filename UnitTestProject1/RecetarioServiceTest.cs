using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;

namespace UnitTestProject1
{
    [TestClass]
    public class RecetarioServiceTest
    {
        [TestMethod]
        public void CocinaRecetaTest()
        {
            IRecetarioService sut = new RecetarioService();

            Alimento mAlimento1 = new Alimento();
            mAlimento1.Nombre = "Alimento1";
            mAlimento1.Peso = 7;
            Alimento mAlimento2 = new Alimento();
            mAlimento2.Nombre = "Alimento2";
            mAlimento2.Peso = 5;
            Receta mReceta = new Receta("Alimento1", "Alimento2", 6, 5);
            Plato resultado = sut.CocinarReceta(mAlimento1, mAlimento2, mReceta);

            Plato plato = new Plato(mAlimento1, mAlimento2);

            Assert.AreEqual(plato, resultado);
        }
    }
}
