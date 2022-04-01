using NUnit.Framework;

namespace TestChallenge19
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestOrdenarNumerosAsc()
        {
            int[] arrayOrdenado = new int[] { 1, 2, 5, 10, 50 };
            int[] enviado = new int[] { 1, 2, 10, 50, 5 };

            Assert.AreEqual(arrayOrdenado, Challenge19.Program.OrdenarNumerosAsc(enviado));
        }
    }
}