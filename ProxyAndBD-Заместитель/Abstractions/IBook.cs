using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyAndBD_Заместитель.Model;

namespace ProxyAndBD_Заместитель.Abstractions
{
    interface IBook : IDisposable
    {
        Page GetPage(int number);
    }
}
