using NUnit.Framework;

namespace TestChallenge18
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFindVowels()
        {
            Assert.AreEqual(2, Challenge18.Program.FindVowels("PAlma"));
        }
    }
}