using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_Итератор.Abstractions;

namespace Iterator_Итератор.MenuIterators
{
    public class MyPancakeHouseMenuIterator : IMyIterator
    {
        private readonly ArrayList _menuItems;
        private int _position;

        public MyPancakeHouseMenuIterator(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            if (_position >= _menuItems.Count || _menuItems[_position] == null)
            {
                return false;
            }
            _position++;
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
