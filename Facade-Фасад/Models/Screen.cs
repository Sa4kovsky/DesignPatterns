using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Фасад.Models
{
    public class Screen
    {
        public void Down()
        {
            Console.WriteLine("Screen going down");
        }

        public void Up()
        {
            Console.WriteLine("Screen going up");
        }
    }
}
