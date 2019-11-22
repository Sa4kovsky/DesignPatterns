using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade_Фасад.Facade;
using Facade_Фасад.Models;

namespace Facade_Фасад
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new HomeTheaterFacade(new Amplifier(), new DvdPlayer(), new Projector(), new TheaterLights(), new Screen(), new PopcornPopper());
            facade.WatchMovie("Ready Player One");
            facade.EndMovie();

            Console.ReadKey();
        }
    }
}
