using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зад3.Switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            bool z = (5 < 6) & (x % 2 == 0);
            Console.WriteLine(z);
        }
    }
}
