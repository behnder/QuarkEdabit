using NUnit.Framework;

namespace TestChallenge14
{
    public class Tests
    {


        [Test]
        public void TestHammingDistance()
        {
            Assert.AreEqual(5, Challenge14.Program.HammingDistance("abcde", "bcdef"));
        }
    }
}