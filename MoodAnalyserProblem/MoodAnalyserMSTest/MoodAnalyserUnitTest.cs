namespace MoodAnalyserMSTest
{
    [TestClass]
    public class MoodAnalyserUnitTest
    {
        [TestMethod]
        public void GivenMoodAnalyser_ShouldReturn_Sad()
        {
            //Expected string will be sad
            string expected = "Sad";

            //now create object of class with i am sad
            MoodAnalyser moodAnalyser = new MoodAnalyser();

        }
    }
}