using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER X AND Y");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            Console.WriteLine(MathOperations.Multiply(x, y));
            Console.ReadKey();
        }
    }
}
