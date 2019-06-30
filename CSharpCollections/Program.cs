using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Hash table.
            Console.WriteLine("Hashtable ");
            Console.WriteLine("Enter the state");
            int i = 0;
            foreach(string key in HashTableWorkOut.hsStates.Keys)
            {
                Console.WriteLine($"{ i++}. {key}");
            }
            string state = Console.ReadLine();
            Console.WriteLine($"HashTable: Capital for the India is: {HashTableWorkOut.FindCapital(state)}");
            //Console.ReadLine();

            // dictiontionary
            Console.WriteLine("Dictionary ");
            Console.WriteLine("Enter the state");
            int j = 0;
            foreach (string key in DictionaryWorkOut.statesDictionary.Keys)
            {
                Console.WriteLine($"{ j++}. {key}");
            }
            string stateDic = Console.ReadLine();
            Console.WriteLine($"Dictionary :Capital for the India is: {DictionaryWorkOut.FindCapital(stateDic)}");
            */
            DictionaryWorkOut.IntializeDictionaryWithNumbers();
            HashTableWorkOut.IntializeHashTableWithNumbers();
            Console.ReadLine();
        }
    }
}
