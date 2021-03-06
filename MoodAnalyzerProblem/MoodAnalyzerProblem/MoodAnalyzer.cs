using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    /// <summary>
    /// public classMood Analyzer
    /// </summary>
    public class MoodAnalyzer
    {//instance variable
        private string Message;
        //constructor for MoodAnalyzer 
        public MoodAnalyzer(string message)
        {
            //this indicate difff of global name and method parrameter
            this.Message = message;
        }
        //method for MoodAnalyzer
        public string AnalyzeMood()
        {
            //if message contains sad
            if (this.Message.Contains("Sad"))
                // it will retrun sad
                return "Sad";
            else
                //else happy
                return "Happy";
        }

    }
}

