using ClassColegio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEsEntero()
        {
            ValidacionNota val = new();
            bool result = val.EsEntero("15");
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestValidacionRangoDeLaNota1()
        {
            ValidacionNota val = new();
            bool result = val.ValidarRango(24);
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void TestValidacionRangoDeLaNota2()
        {
            ValidacionNota val = new();
            bool result = val.ValidarRango(20);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestPromedio1()
        {
            Evalucion eva = new();
            double result = eva.CalcPromedio(15, 16, 17);
            Assert.AreEqual(result, 16);
        }

        [TestMethod]
        public void TestPromedio2()
        {
            Evalucion eva = new();
            double result = eva.CalcPromedio(16, 17, 17);
            Assert.AreEqual(result, 16.67);
        }

        [TestMethod]
        public void TestSituacion1()
        {
            Evalucion eva = new();
            string result = eva.EvaSituacion(16);
            Assert.AreEqual(result, "EXCELENTE");
        }

        [TestMethod]
        public void TestSituacion2()
        {
            Evalucion eva = new();
            string result = eva.EvaSituacion(10);
            Assert.AreEqual(result, "SUSTITUTORIO");
        }
    }
}
