using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Moq;

namespace UnitTestProject1
{

    [TestClass]
    public class RecetaServiceTest
    {

        [TestMethod]
        public void TestGuardarReceta()
        {
            var mockRecetaRepository = new Mock<IRecetaRepository>();
            Receta receta = new Receta();

            IRecetaService sut = new RecetaService(mockRecetaRepository.Object);
            sut.Guardar(receta);

            mockRecetaRepository.Verify(recetaRepository => recetaRepository.add(It.IsAny<Receta>()), Times.Once);
        }
    }
}
