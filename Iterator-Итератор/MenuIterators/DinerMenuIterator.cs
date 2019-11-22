using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_Итератор.Menu;

namespace Iterator_Итератор.MenuIterators
{
    public class DinerMenuIterator : IEnumerator
    {
        private readonly MenuItem[] _menuItems;
        private int _position = -1;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
        }

        public bool MoveNext()
        {
            _position++;
            if (_position >= _menuItems.Length || _menuItems[_position] == null)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current => _menuItems[_position];
    }
}
