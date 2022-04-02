using NUnit.Framework;

namespace TestChallenge23
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMultiplicarArray()
        {
            int[] arrayEsperado = new int[] { 7, 14, 21, 28, 35 };
            Assert.AreEqual(arrayEsperado,  Challenge23.Program.MultiplicarArray(7,5));
        }
    }
}