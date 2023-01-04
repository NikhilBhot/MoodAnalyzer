using MoodAnalyzerApp;

namespace MoodAnalyzerMSTest
{
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            string expected = "SAD";
            string message = "I am in Sad Mood";

            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

            string mood = moodAnalyzer.AnalyzeMood();

            Assert.AreEqual(expected, mood);

        }

        [TestMethod]
       // [DataRow("I am in Happy Mood")]
        [DataRow(null)]
        public void GivenHappyMoodShouldReturnHappy(string message)
        {
            string expected = "HAPPY";
           // string message = "I am in Happy Mood";

            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);

            string mood = moodAnalyzer.AnalyzeMood();

            Assert.AreEqual(expected, mood);

        }


    }
}