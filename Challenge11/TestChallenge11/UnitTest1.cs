using NUnit.Framework;

namespace TestChallenge11
{
    public class Tests
    {

        [Test]
        public void TestSumaAbsoluta()
        {
            int[] enviado = new int[] { 2, -1, 4, 8, 10 };
            Assert.AreEqual(25, Challenge11.Program.SumaAbsoluta(enviado));
        }
    }
}