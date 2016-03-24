using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge.Interfaces;

namespace Bridge
{
    public class Fan : IElectricalEquipment
    {
        public void PowerOn()
        {
            Console.WriteLine("Fan is on");
        }

        public void PowerOff()
        {
            Console.WriteLine("Fan is off");
        }
    }
}
