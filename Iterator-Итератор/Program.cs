using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_Итератор.Menu.Models;
using Iterator_Итератор.Waitresses;

namespace Iterator_Итератор
{/*Разобрана два итератора: Первый с приставкой "MY" сделанный в ручную, второй предоставляемый C#*/
    class Program
    {
        static void Main(string[] args)
        {
            MenuTestDriveUsingMyIterator();
            Console.WriteLine("*********************");
            MenuTestDriveUsingIEnumerator();
            Console.ReadKey();
        }

        static void MenuTestDriveUsingMyIterator()
        {
            var pancakeHouseMenu = new MyPancakeHouseMenu();
            var dinerMenu = new MyDinerMenu();

            var waitress = new MyWaitress(pancakeHouseMenu, dinerMenu);
            waitress.PrintMenu();
        }

        static void MenuTestDriveUsingIEnumerator()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
           // var cafeMenu = new CafeMenu();

            var waitress = new Waitress(new ArrayList(3)
            {
                pancakeHouseMenu, dinerMenu
            });
            waitress.PrintMenu();
        }
    }
}
