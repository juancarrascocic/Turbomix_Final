using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class TurbomixServiceTest
    {
        [TestMethod]
        public void TestPrepararPlato2()
        {
            var mockBasculaService = new Mock<IBasculaService>();
            var mockCocinaService = new Mock<ICocinaService>();
            var mockRecetaRepository = new Mock<IRecetaRepository>();

            mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimento>())).Returns((Alimento p) => p.Peso);
            //mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimento>())).Returns(1.5F);

            mockCocinaService.Setup(cocina => cocina.Calentar(It.IsAny<Alimento>(), It.IsAny<Alimento>())).
                Callback((Alimento p1, Alimento p2) =>
                {
                    p1.Calentado = true;
                    p2.Calentado = false;
                });

            IBasculaService basculaService = mockBasculaService.Object;
            ICocinaService cocinaService = mockCocinaService.Object;
            IRecetaRepository recetaRepository = mockRecetaRepository.Object;

            TurbomixService sut = new TurbomixService(basculaService, cocinaService);
            Alimento mAlimento1 = new Alimento();
            mAlimento1.Nombre = "Curry";
            mAlimento1.Peso = 1.5F;
            Alimento mAlimento2 = new Alimento();
            mAlimento2.Nombre = "Queso";
            mAlimento2.Peso = 5F;

            Plato resultado = sut.PrepararPlato(mAlimento1, mAlimento2);


            mockBasculaService.Verify(bascula => bascula.Pesar(It.IsAny<Alimento>()), Times.AtLeast(2));

            mockCocinaService.Verify(cocina => cocina.Calentar(It.IsAny<Alimento>(), It.IsAny<Alimento>()), Times.AtLeast(1));


            Plato mPlato = new Plato(mAlimento1, mAlimento2);
            Assert.AreEqual(mPlato, resultado);
        }
    }
}
