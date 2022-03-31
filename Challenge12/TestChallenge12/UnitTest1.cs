using NUnit.Framework;

namespace TestChallenge12
{
    public class Tests
    {

        [Test]
        public void TestPotenciaDe()
        {
            Assert.AreEqual(3125, Challenge12.Program.PotenciaDe(5));
        }
    }
}