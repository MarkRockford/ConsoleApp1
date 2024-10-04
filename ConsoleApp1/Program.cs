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
            int x = 0;
            int y = 0;
            Console.WriteLine("ENTER X AND Y");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            int p = x * y;
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
