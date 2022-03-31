using NUnit.Framework;

namespace TestChallenge08
{
    public class Tests
    {
    
        [Test]
        public void TestAreaTriangulo()
        {
            Assert.AreEqual(3, Challenge08.Program.AreaTriangulo(3, 2));
        }
    }
}