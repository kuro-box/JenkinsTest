using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("Hello Debug World!");
#else
            Console.WriteLine("Hello Release World!");
#endif
            Console.ReadKey();
        }
    }
}
