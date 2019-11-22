using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMetodi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEsempio1()
        {
            bool risp = Metodi.ClasseMetodi.Esempio1();
            Assert.AreEqual(true, risp);
        }
        [TestMethod]

        public void TestEsempio2()
        {
            bool risp = Metodi.ClasseMetodi.Esempio1();
            Assert.AreEqual(true, risp);
        }
    }
}
