using NUnit.Framework;

namespace TestChallenge22
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestReverseTheCase()
        {
            Assert.AreEqual("hAPPY bIRThDAY", Challenge22.Program.ReverseTheCase("Happy BirtHday"));
        }
    }
}