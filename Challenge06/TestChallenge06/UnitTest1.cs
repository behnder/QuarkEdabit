using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChallenge06
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConvertirNumeroAMes()
        {
            Assert.AreEqual("Marzo", Challenge06.Program.ConvertirNumeroAMes(3));
        }
    }
}
