using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    public static class TypeExtensions
    {
        public static void Print(this object obj)
        {
            Console.WriteLine(obj);
        }

        //public static string Format(this string formatString, params object[] args)
        //{
        //    return string.Format(formatString, args);
        //}
    }
}
