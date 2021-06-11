using ConversorRomanos.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConversorRomanos.Tests
{
    [TestClass]
    public class RomanoParaInteiroTest
    {
        readonly Romano romano = new Romano();

        [TestMethod]
        public void DeveRetornar1()
        {
            Assert.AreEqual(1, romano.ConverterRomanoParaInteiro("I"));
        }

        [TestMethod]
        public void DeveRetornar4()
        {
            Assert.AreEqual(4, romano.ConverterRomanoParaInteiro("IV"));
        }

        [TestMethod]
        public void DeveRetornar5()
        {
            Assert.AreEqual(5, romano.ConverterRomanoParaInteiro("V"));
        }

        [TestMethod]
        public void DeveRetornar9()
        {
            Assert.AreEqual(9, romano.ConverterRomanoParaInteiro("IX"));
        }

        [TestMethod]
        public void DeveRetornar10()
        {
            Assert.AreEqual(10, romano.ConverterRomanoParaInteiro("X"));
        }

        [TestMethod]
        public void DeveRetornar49()
        {
            Assert.AreEqual(49, romano.ConverterRomanoParaInteiro("XLIX"));
        }

        [TestMethod]
        public void DeveRetornar50()
        {
            Assert.AreEqual(50, romano.ConverterRomanoParaInteiro("L"));
        }

        [TestMethod]
        public void DeveRetornar100()
        {
            Assert.AreEqual(100, romano.ConverterRomanoParaInteiro("C"));
        }

        [TestMethod]
        public void DeveRetornar400()
        {
            Assert.AreEqual(400, romano.ConverterRomanoParaInteiro("CD"));
        }

        [TestMethod]
        public void DeveRetornar500()
        {
            Assert.AreEqual(500, romano.ConverterRomanoParaInteiro("D"));
        }

        [TestMethod]
        public void DeveRetornar900()
        {
            Assert.AreEqual(900, romano.ConverterRomanoParaInteiro("CM"));
        }

        [TestMethod]
        public void DeveRetornar1000()
        {
            Assert.AreEqual(1000, romano.ConverterRomanoParaInteiro("M"));
        }

        [TestMethod]
        public void DeveRetornar4000()
        {
            Assert.AreEqual(4000, romano.ConverterRomanoParaInteiro("ĪV̄"));
        }

        [TestMethod]
        public void DeveRetornar5000()
        {
            Assert.AreEqual(5000, romano.ConverterRomanoParaInteiro("V̄"));
        }

        [TestMethod]
        public void DeveRetornar4999()
        {
            Assert.AreEqual(4999, romano.ConverterRomanoParaInteiro("ĪV̄CMXCIX"));
        }

        [TestMethod]
        public void DeveRetornar6000()
        {
            Assert.AreEqual(6000, romano.ConverterRomanoParaInteiro("V̄Ī"));
        }

        [TestMethod]
        public void DeveRetornar7000()
        {
            Assert.AreEqual(7000, romano.ConverterRomanoParaInteiro("V̄ĪĪ"));
        }

        [TestMethod]
        public void DeveRetornar8000()
        {
            Assert.AreEqual(8000, romano.ConverterRomanoParaInteiro("V̄ĪĪĪ"));
        }

        [TestMethod]
        public void DeveRetornar9000()
        {
            Assert.AreEqual(9000, romano.ConverterRomanoParaInteiro("ĪX̄"));
        }

        [TestMethod]
        public void DeveRetornar10000()
        {
            Assert.AreEqual(10000, romano.ConverterRomanoParaInteiro("X̄"));
        }

        [TestMethod]
        public void DeveRetornar20000()
        {
            Assert.AreEqual(20000, romano.ConverterRomanoParaInteiro("X̄X̄"));
        }

        [TestMethod]
        public void DeveRetornar30000()
        {
            Assert.AreEqual(30000, romano.ConverterRomanoParaInteiro("X̄X̄X̄"));
        }

        [TestMethod]
        public void DeveRetornar40000()
        {
            Assert.AreEqual(40000, romano.ConverterRomanoParaInteiro("X̄L̄"));
        }

        [TestMethod]
        public void DeveRetornar50000()
        {
            Assert.AreEqual(50000, romano.ConverterRomanoParaInteiro("L̄"));
        }

        [TestMethod]
        public void DeveRetornar100000()
        {
            Assert.AreEqual(100000, romano.ConverterRomanoParaInteiro("C̄"));
        }

        [TestMethod]
        public void DeveRetornar150000()
        {
            Assert.AreEqual(150000, romano.ConverterRomanoParaInteiro("C̄L̄"));
        }

        [TestMethod]
        public void DeveRetornar500000()
        {
            Assert.AreEqual(500000, romano.ConverterRomanoParaInteiro("D̄"));
        }

        [TestMethod]
        public void DeveRetornar1000000()
        {
            Assert.AreEqual(1000000, romano.ConverterRomanoParaInteiro("M̄"));
        }

        [TestMethod]
        public void DeveRetornar1000001()
        {
            Assert.AreEqual(1000001, romano.ConverterRomanoParaInteiro("M̄I"));
        }

        [TestMethod]
        public void DeveRetornar1110000()
        {
            Assert.AreEqual(1110000, romano.ConverterRomanoParaInteiro("M̄C̄X̄"));
        }

        [TestMethod]
        public void DeveRetornar5000000()
        {
            Assert.AreEqual(5000000, romano.ConverterRomanoParaInteiro("M̄M̄M̄M̄M̄"));
        }
    }
}
