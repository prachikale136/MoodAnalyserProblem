

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyser_ShouldReturn_Sad()
        {
            //Expected string will be sad
            string expected = "Sad";

            //now create object of class with i am sad
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am Sad");
            Assert.AreEqual(expected, moodAnalyser.MoodAnalyze());
        }

        [TestMethod]
        public void GivenMoodAnalyser_ShouldReturn_Happy()
        {
            string expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am Happy");
            Assert.AreEqual(expected, moodAnalyser.MoodAnalyze());
        }
        [TestMethod]
        public void GivenNullMood_ShouldReturn_Happy()
        {
            string expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string mood = moodAnalyser.MoodAnalyze();
            Assert.AreEqual(expected, mood);

        }
    }
}