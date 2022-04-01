using NUnit.Framework;

namespace TestChallenge20
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCaracteresIdenticos()
        {
            Assert.AreEqual(true, Challenge20.Program.CaracteresIdenticos("aaaaaa"));
        }
    }
}