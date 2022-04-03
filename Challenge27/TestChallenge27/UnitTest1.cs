using NUnit.Framework;

namespace TestChallenge27
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPilishString()
        {
            string enviado = "HOWINEEDADRINKALCOHOLICINNATUREAFTERTHEHEAVYLECTURESINVOLVINGQUANTUMMECHANICSANDALLTHESECRETSOFTHEUNIVERSE";
            string piResultado = "HOW I NEED A DRINK ALCOHOLIC IN NATURE AFTER THE HEAVY LECTURES INVOLVING QUANTUM MECHANICS";

            Assert.AreEqual(piResultado, Challenge27.Program.PilishString(enviado));
        }


    }
}