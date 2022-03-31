using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChallenge05
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConvertirAniosADias()
        {
            Assert.AreEqual(23725, Challenge05.Program.ConvertirAniosADias(-65));
        }
    }
}
