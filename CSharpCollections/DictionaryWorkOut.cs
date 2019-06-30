using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    public class DictionaryWorkOut
    {
        public static Dictionary<string, string> statesDictionary = new Dictionary<string, string>()
        {
            {"Delhi","Delhi" },
            {"AP","Amaravathi" },
            {"TA","Hyderabad" },
            {"KN","Bangalore" },
            {"TN","Chennai" },
            {"MP","Bhopal" },
            {"MH","Mubai" },
            {"UP","Lucknow" }
        };
        public static Dictionary<string, int> numbersDictionary = new Dictionary<string, int>();
        public static string FindCapital(string State)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string capital = !String.IsNullOrEmpty(statesDictionary[State]) ? statesDictionary[State] : "Not Found";
            timer.Stop();
            Console.WriteLine($"Dictionary : Execution time in milli seconds{timer.ElapsedMilliseconds}");
            return capital;
        }

        public static void IntializeDictionaryWithNumbers()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 1000; i++)
            {
                numbersDictionary.Add("i" + i, i);
            }
            timer.Stop();
            Console.WriteLine($"Intialised Dictionary in {timer.ElapsedMilliseconds}: milliseconds");
        }

        public object findValue(int number)
        {
            return numbersDictionary["i" + 1];
        }
    }
}
