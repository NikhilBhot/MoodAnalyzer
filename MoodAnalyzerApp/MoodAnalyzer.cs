using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerApp
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;

        }
        public string AnalyzeMood()
        {
            if (this.message.Contains("Sad"))                          //TC1.1
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }

        }
    }
}
