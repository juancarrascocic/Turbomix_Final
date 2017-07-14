using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;

namespace UnitTestProject1
{
    [TestClass]
    public class TermometroTest
    {
        [TestMethod]
        public void MedirTemperaturaTest()
        {
            ITermometro sut = new Termometro();
            Alimento mAlimento = new Alimento(7, false);
            bool resultado = sut.MedirTemperatura(mAlimento);

            Assert.IsFalse(resultado);
        }
    }
}
