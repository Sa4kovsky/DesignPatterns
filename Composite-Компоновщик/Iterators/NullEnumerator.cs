using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite_Компоновщик.Abstract;

namespace Composite_Компоновщик.Iterators
{
    public class NullEnumerator : IEnumerator<MenuComponent>
    {
        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {

        }

        public MenuComponent Current => null;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
