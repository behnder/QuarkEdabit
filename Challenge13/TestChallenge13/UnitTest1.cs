using NUnit.Framework;

namespace TestChallenge13
{
    public class Tests
    {
        [Test]
        public void TestMultiplicarPorLongitudDeArray()
        {
            int[] enviado = new int[] { 2, 3, 1, 0 };
            int[] esperado = new int[] { 8, 12, 4, 0 };


            Assert.AreEqual(esperado, Challenge13.Program.MultiplicarPorLongitudDeArray(enviado));
        }
    }
}