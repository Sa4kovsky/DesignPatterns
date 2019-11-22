using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Комады.Device
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("GarageDoor is open.");
        }

        public void Down()
        {
            Console.WriteLine("GarageDoor is closed.");
        }
    }
}
