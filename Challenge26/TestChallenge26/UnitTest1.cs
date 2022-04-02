using NUnit.Framework;

namespace TestChallenge26
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAlphabeticalOrder()
        {
            string cadenaEnviada= "edabit is awesome";
            string retorno = "aabdee ei imosstw";

            Assert.AreEqual(retorno, Challenge26.Program.AlphabeticalOrder(cadenaEnviada));
        }
    }
}