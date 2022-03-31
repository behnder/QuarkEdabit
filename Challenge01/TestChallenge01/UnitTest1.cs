using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge01;


namespace TestChallenge01
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestSumaDeDosNumeros()
        {            
            Assert.AreEqual(2, Challenge01.Program.SumaDeDosNumeros(1,1));
        }
    }
}


/*

  public static int Add(string numbers) {
            // throw new NotImplementedException();
            // return int.MinValue;
            return 0;
        }

 [Test] public void Add_EmptyStringAsParam_ReturnsZero() {
            Assert.AreEqual(0, StringCalculator.Add(""));
        }
*/