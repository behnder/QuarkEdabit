using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChallenge07
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMaximoYMinimo()
        {
            int[] esperado = new int []{1,5};
            int[] enviado = new int []{ 1, 5 };

            CollectionAssert.AreEqual(esperado, Challenge07.Program.MaximoYMinimo(enviado));
        }



    }
}
