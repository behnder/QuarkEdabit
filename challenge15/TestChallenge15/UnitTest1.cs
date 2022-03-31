using NUnit.Framework;

namespace TestChallenge15
{
    public class Tests
    {


        [Test]
        public void TestIntercambiarNombres()
        {
            Assert.AreEqual("Trump Donald", challenge15.Program.IntercambiarNombres("Donald Trump"));
        }
    }
}