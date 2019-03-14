using System;
using conversor_romano;
using NUnit.Framework;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void DeveRetornarExceptionSeIniciarZero()
        {
            var calculos = new Calculos();
            Assert.Throws<ArgumentException>(() =>  calculos.converterInteiroRomano(0));
        }

        [Test]
        public void DeveRetornarExceptionSeIniciar3001()
        {
            var calculos = new Calculos();
            Assert.Throws<ArgumentException>(() =>  calculos.converterInteiroRomano(3001));
        }

        [Test]
        public void ValorEsperado()
        {
            var calculos = new Calculos();
            string valorEsperado = "V";
            string valorEncontrado = calculos.converterInteiroRomano(5);
            Assert.AreSame(valorEsperado, valorEncontrado);
        }

    }
}