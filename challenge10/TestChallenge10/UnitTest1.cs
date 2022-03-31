using NUnit.Framework;

namespace TestChallenge10
{
    public class Tests
    {

        [Test]

        public void TestMenorOIgualAcero()
        {
            Assert.AreEqual(false, challenge10.Program.MenorOIgualAcero(5));
        }


    }
}