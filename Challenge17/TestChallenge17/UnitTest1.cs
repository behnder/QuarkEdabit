using NUnit.Framework;

namespace TestChallenge17
{
    public class Tests
    {


        [Test]
        public void TestObtenerFactorial()
        {
            Assert.AreEqual(479001600, Challenge17.Program.ObtenerFactorial(12));
        }
    }
}