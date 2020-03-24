using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Int32.Parse(Console.ReadLine());
            Support s = new Support(a, b);
            Console.WriteLine("Return: " + s.Ret());
            Console.ReadLine();
        }
    }

    class Kpss
    {
        public string Stalin { get { return "The Best"; } }
        public int Calc { get { return 2 + 2; } }
        public Kpss()
        {
            Console.WriteLine(this.Stalin);
        }
        

    }
}
