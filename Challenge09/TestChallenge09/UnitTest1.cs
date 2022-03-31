using NUnit.Framework;

namespace TestChallenge09
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDevolverResto()
        {
            Assert.AreEqual(1, Challenge09.Program.DevolverResto(1,3));
        }
    }
}