namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Problem");
            MoodAnalyser moodAnalyser = new MoodAnalyser("Sad");
            var obj = moodAnalyser.MoodAnalyze();
            Console.WriteLine(obj);
        }
    }
}