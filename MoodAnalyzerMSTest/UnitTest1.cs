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
    }
}