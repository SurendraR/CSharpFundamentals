using System;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    public class HashTableWorkOut
    {
        public static Hashtable hsStates = new Hashtable() {
            {"Delhi","Delhi" },
            {"AP","Amaravathi" },
            {"TA","Hyderabad" },
            {"KN","Bangalore" },
            {"TN","Chennai" },
            {"MP","Bhopal" },
            {"MH","Mubai" },
            {"UP","Lucknow" }
        };

        public static Hashtable hsNumbers = new Hashtable();
        public static string FindCapital(string State)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string capital= !String.IsNullOrEmpty(hsStates[State].ToString()) ? hsStates[State].ToString() : "Not Found";
            timer.Stop();
            Console.WriteLine($"Hashtable: Execution time in milli seconds{timer.ElapsedMilliseconds}");

            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(i);
            }

            watch.Stop();

            Console.WriteLine($"Timer test : Execution Time: {watch.ElapsedMilliseconds} ms");

            return capital;
        }

        public static void IntializeHashTableWithNumbers()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i=0; i < 1000; i++)
            {
                hsNumbers.Add("i"+i, i);
            }
            timer.Stop();
            Console.WriteLine($"Intialised Hashtable in {timer.ElapsedMilliseconds}: milliseconds");
        }

        public object findValue(int number)
        {
            return hsNumbers["i"+1];
        }
    }
}
