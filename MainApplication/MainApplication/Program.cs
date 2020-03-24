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
            Console.WriteLine("Hello world");
            Console.ReadLine();
        }
    }

    class Kpss
    {
        public string Stalin { get { return "The Best"; } }
        public Kpss()
        {
            Console.WriteLine(this.Stalin);
        }
    }
}
