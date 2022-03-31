using NUnit.Framework;

namespace TestChallenge16
{
    public class Tests
    {

        [Test]
        public void TestStringNumeroMenor()
        {
            Assert.AreEqual("21", Challenge16.Program.StringNumeroMenor("21", "44"));
        }
    }
}