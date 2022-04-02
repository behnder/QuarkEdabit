using NUnit.Framework;

namespace TestChallenge25
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConsecutiveNumbers()
        {
            int[]  enviado = { 5, 4, 6, 3, 2 };

            Assert.AreEqual(true , Challenge25.Program.ConsecutiveNumbers(enviado));
        }
    }
}