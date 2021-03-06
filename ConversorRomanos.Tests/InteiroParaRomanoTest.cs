using ConversorRomanos.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConversorRomanos.Tests
{
    [TestClass]
    public class InteiroParaRomanoTest
    {
        readonly Romano romano = new Romano();

        [TestMethod]
        public void DeveRetornarI()
        {
            Assert.AreEqual("I", romano.ConverterInteiroParaRomano(1));
        }

        [TestMethod]
        public void DeveRetornarIV()
        {
            Assert.AreEqual("IV", romano.ConverterInteiroParaRomano(4));
        }

        [TestMethod]
        public void DeveRetornarV()
        {
            Assert.AreEqual("V", romano.ConverterInteiroParaRomano(5));
        }

        [TestMethod]
        public void DeveRetornarVII()
        {
            Assert.AreEqual("VII", romano.ConverterInteiroParaRomano(7));
        }

        [TestMethod]
        public void DeveRetornarIX()
        {
            Assert.AreEqual("IX", romano.ConverterInteiroParaRomano(9));
        }

        [TestMethod]
        public void DeveRetornarX()
        {
            Assert.AreEqual("X", romano.ConverterInteiroParaRomano(10));
        }

        [TestMethod]
        public void DeveRetornarXII()
        {
            Assert.AreEqual("XII", romano.ConverterInteiroParaRomano(12));
        }

        [TestMethod]
        public void DeveRetornarXIV()
        {
            Assert.AreEqual("XIV", romano.ConverterInteiroParaRomano(14));
        }

        [TestMethod]
        public void DeveRetornarXIX()
        {
            Assert.AreEqual("XIX", romano.ConverterInteiroParaRomano(19));
        }

        [TestMethod]
        public void DeveRetornarXL()
        {
            Assert.AreEqual("XL", romano.ConverterInteiroParaRomano(40));
        }

        [TestMethod]
        public void DeveRetornarLXXIX()
        {
            Assert.AreEqual("LXXIX", romano.ConverterInteiroParaRomano(79));
        }

        [TestMethod]
        public void DeveRetornarVC()
        {
            Assert.AreEqual("XCV", romano.ConverterInteiroParaRomano(95));
        }

        [TestMethod]
        public void DeveRetornarC()
        {
            Assert.AreEqual("C", romano.ConverterInteiroParaRomano(100));
        }

        [TestMethod]
        public void DeveRetornarCD()
        {
            Assert.AreEqual("CD", romano.ConverterInteiroParaRomano(400));
        }

        [TestMethod]
        public void DeveRetornarD()
        {
            Assert.AreEqual("D", romano.ConverterInteiroParaRomano(500));
        }

        [TestMethod]
        public void DeveRetornarCM()
        {
            Assert.AreEqual("CM", romano.ConverterInteiroParaRomano(900));
        }

        [TestMethod]
        public void DeveRetornarĪV̄()
        {
            Assert.AreEqual("ĪV̄", romano.ConverterInteiroParaRomano(4000));
        }

        [TestMethod]
        public void DeveRetornarĪV̄CMXCIX()
        {
            Assert.AreEqual("ĪV̄CMXCIX", romano.ConverterInteiroParaRomano(4999));
        }
        
        [TestMethod]
        public void DeveRetornarV̄()
        {
            Assert.AreEqual("V̄", romano.ConverterInteiroParaRomano(5000));
        }

        [TestMethod]
        public void DeveRetornarĪX̄()
        {
            Assert.AreEqual("ĪX̄", romano.ConverterInteiroParaRomano(9000));
        }

        [TestMethod]
        public void DeveRetornarX̄()
        {
            Assert.AreEqual("X̄", romano.ConverterInteiroParaRomano(10000));
        }

        [TestMethod]
        public void DeveRetornarX̄X̄()
        {
            Assert.AreEqual("X̄X̄", romano.ConverterInteiroParaRomano(20000));
        }

        [TestMethod]
        public void DeveRetornarX̄X̄X̄()
        {
            Assert.AreEqual("X̄X̄X̄", romano.ConverterInteiroParaRomano(30000));
        }

        [TestMethod]
        public void DeveRetornarL̄()
        {
            Assert.AreEqual("L̄", romano.ConverterInteiroParaRomano(50000));
        }

        [TestMethod]
        public void DeveRetornarC̄()
        {
            Assert.AreEqual("C̄", romano.ConverterInteiroParaRomano(100000));
        }

        [TestMethod]
        public void DeveRetornarC̄L̄()
        {
            Assert.AreEqual("C̄L̄", romano.ConverterInteiroParaRomano(150000));
        }

        [TestMethod]
        public void DeveRetornarD̄()
        {
            Assert.AreEqual("D̄", romano.ConverterInteiroParaRomano(500000));
        }

        [TestMethod]
        public void DeveRetornarM̄()
        {
            Assert.AreEqual("M̄", romano.ConverterInteiroParaRomano(1000000));
        }

        [TestMethod]
        public void DeveRetornarM̄I()
        {
            Assert.AreEqual("M̄I", romano.ConverterInteiroParaRomano(1000001));
        }

        [TestMethod]
        public void DeveRetornarM̄C̄X̄()
        {
            Assert.AreEqual("M̄C̄X̄", romano.ConverterInteiroParaRomano(1110000));
        }

    }
}