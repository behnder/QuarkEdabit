using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChallenge03
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SiguienteNumero()
        {
            Assert.AreEqual(1, Challenge03.Program.SiguienteNumero(0));
        }
    }
}
