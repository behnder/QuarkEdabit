using NUnit.Framework;

namespace TestChallenge21
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFindLargestnumberOfArray()
        {
            double[] esperado = new double[] { 7, 90, 2 };

            double[][] enviado = new double[3][] {
             new double [] { 4, 2, 7, 1},
             new double [] {20, 70, 40, 90 },
             new double [] { 1, 2, 0 }
            };

            Assert.AreEqual(esperado, Challenge21.Program.FindLargestnumberOfArray(enviado));
        }
    }
}