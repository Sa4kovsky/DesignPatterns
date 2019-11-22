using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_Итератор.Abstractions;
using Iterator_Итератор.Menu;
using Iterator_Итератор.Menu.Models;

namespace Iterator_Итератор.Waitresses
{
    public class MyWaitress
    {
        private readonly MyPancakeHouseMenu _pancakeHouseMenu;
        private readonly MyDinerMenu _dinerMenu;

        public MyWaitress(MyPancakeHouseMenu pancakeHouseMenu, MyDinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = _pancakeHouseMenu.CreateIterator();
            var dinerIterator = _dinerMenu.CreateIterator();
            Console.WriteLine("MENU\n--------------\nBREAKFIRST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IMyIterator iterator)
        {
            while (iterator.HasNext())
            {
                var menuItem = iterator.Next() as MenuItem;
                Console.Write($"{menuItem?.Name}, ");
                Console.Write($"{menuItem?.Price} -- ");
                Console.WriteLine($"{menuItem?.Description}");
            }
        }
    }
}
