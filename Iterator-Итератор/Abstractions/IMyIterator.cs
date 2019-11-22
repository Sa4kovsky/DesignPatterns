using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Итератор.Abstractions
{
    public interface IMyIterator
    {
        bool HasNext();
        object Next();
    }
}
