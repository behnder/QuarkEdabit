using NUnit.Framework;

namespace TestChallenge17
{
    public class Tests
    {


        [Test]
        public void TestObtenerFactorial()
        {
            Assert.AreEqual(6,Challenge17.Program.ObtenerFactorial(3));
        }
    }
}