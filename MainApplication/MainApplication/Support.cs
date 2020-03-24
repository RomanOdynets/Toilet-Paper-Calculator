using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    class Support
    {
        public int a { get; private set; }
        public int b { get; private set; }
        public Support(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Ret()
        {
            return a % b;
        }
    }
}
