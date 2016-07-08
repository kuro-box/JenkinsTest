using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    public class Messages
    {
        public static string HelloMessage
        {
            get
            {
#if DEBUG
                return "Hello Debug World!";
#else
                return "Hello Release World!";
#endif
            }
        }

        public string GetMessage(object obj)
        {
            return $"obj is {obj}";
        }
    }
}
