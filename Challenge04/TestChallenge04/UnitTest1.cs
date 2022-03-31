using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChallenge04
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalcularPotencia()
        {
            Assert.AreEqual(2300, Challenge04.Program.CalcularPotencia(230, 10));
        }
    }
}
