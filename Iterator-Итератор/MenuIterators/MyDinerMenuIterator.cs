using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_Итератор.Abstractions;
using Iterator_Итератор.Menu;

namespace Iterator_Итератор.MenuIterators
{
    public class MyDinerMenuIterator : IMyIterator
    {
        private readonly MenuItem[] _menuItems;
        private int _position;

        public MyDinerMenuIterator(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            if (_position >= _menuItems.Length || _menuItems[_position] == null)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            var menuItem = _menuItems[_position];
            _position++;
            return menuItem;
        }
    }
}
