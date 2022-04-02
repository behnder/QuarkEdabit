using NUnit.Framework;

namespace TestChallenge24
{
    public class Tests
    {

        [Test]
        public void TestTrackRobot()
        {
            string[] enviado = new string[] { "right 10", "up 50", "left 30", "down 10" };
            int[] resultado = new int[] { -20,40 };
            Assert.AreEqual(resultado, Challenge24.Program.TrackRobot(enviado));
        }
    }
}