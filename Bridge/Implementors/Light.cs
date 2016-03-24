using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge.Interfaces;

namespace Bridge
{
    public class Light : IElectricalEquipment
    {
        public void PowerOn()
        {
            Console.WriteLine("Light is on");
        }

        public void PowerOff()
        {
            Console.WriteLine("Light is off");
        }
    }
}
