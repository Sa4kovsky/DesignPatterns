using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Заместитель
{
    class Program
    {
        static void Main(string[] args)
        {
            int _count = 0;

            if (args.Length < 2)
            {
                Console.WriteLine("GumballMachine ");
            }

            _count = args[1];
        }
    }
}
