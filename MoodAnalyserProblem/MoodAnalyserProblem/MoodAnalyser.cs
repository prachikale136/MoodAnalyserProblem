using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    internal class MoodAnalyser
    {
        private string Message;
         public MoodAnalyser(string message)
        {
             this.Message = message;
        }

        public string MoodAnalyze()
        {
            try
            {
                if (this.Message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch
            {
                return "Happy";
            }
           
        }
    }
}
