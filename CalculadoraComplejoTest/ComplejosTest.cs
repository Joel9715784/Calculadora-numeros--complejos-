using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraLogica;
using System;
namespace calculadoraComplejoTest
{
    [TestClass]
    public class ComplejosTest
    {
        [TestMethod]
        public void SumarNumerosComplejos()
        {
            var complejo1 = new Complejo(4, 4);
            var complejo2 = new Complejo(6, 6);

            var resultado = new Complejo(12, 12);

            var miCalculadora = new Calculadora();

            var resultafofinal = miCalculadora.Sumar(complejo1, complejo2);

            Assert.AreEqual(resultado.Real, resultadofinal.Real);

            Assert.AreEqual(resultado.Imaginaria, resultadofinal.Imaginaria);

        }

        [TestMethod]
        public void RestarNumeroComplejos()
        {
            var comlejo1 = new Complejo(6, 8);
            var complejo2 = new Complejo(3, 5);

            var resultado = new Complejo(3, 3);

            var miCalculadora = new Calculadora();

            var resultado = miCalculadora.Restar(complejo1, complejo2);

            Assert.AreEqual(resultado.Real, resultadofinal.Real);

            Assert.AreEqual(resultado.Imaginaria, resultadofinal.Imaginaria);

        }

        [TestMethod]

        public void MultiplicarComplejos()
        {
            var complejo1 = new Complejo(5, 2);
            var complejo2 = new Complejo(4, 4);
            var resultado = new Complejo(12, 28);

            var micalculadora = new Calculadora();

            var resultado = micalculadora.Multiplicar(primerComplejo, segundoComplejo);

            Assert.AreEqual(resultado.Real, resultadofinal.Real);

            Assert.AreEqual(resultado.Imaginaria, resultadofinal.Imaginaria);
        }

        [TestMethod]

        public void DividirComplejos()
        {
            var complejo1 = new Complejo(6, 5);
            var complejo2 = new Complejo(5, 4);
            var resultado = new Complejo(50/29, 1/29);

            var miCalculadora = new Calculadora();

            var resultadofinal = miCalculadora.Dividir(complejo1, complejo2);
            
            Assert.AreEqual(resultado.Real, resultadofinal.Real);

            Assert.AreEqual(resultado.Imaginaria, resultadofinal.Imaginaria);
        }

        public void multiplicarPorescala()
        {
            var escala = 2;

            var complejo = new Complejo(4, 6);

            var resultado = new Complejo(8, 12);

            var micalculadora = new Calculadora();

            var resultadofinal = micalculadora.multiplicarEscalar(escala, complejo);

            Assert.AreEqual(resultado.Real, resultadofinal.Real);

            Assert.AreEqual(resultado.Imaginaria, resultadofinal.Imaginaria);

        }
    }
}
