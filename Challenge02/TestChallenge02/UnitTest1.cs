using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChallenge02
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMinutosASegundos()
        {

            Assert.AreEqual(300, Challenge02.Program.MinutosASegundos(5));
        }
    }
}
