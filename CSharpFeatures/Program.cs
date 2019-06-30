using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public delegate void HelloFunctionDelegate(string Message);
    class Program
    {
        static void Main(string[] args)
        {
            // A delegate is a type safe function pointer.
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from delegate!!!");
            Console.ReadLine();
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}
