using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = SIHelper.GetUCName();
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
