using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge.Interfaces;

namespace Bridge
{
    public abstract class Switch
    {
        public IElectricalEquipment Equipment { get; set; }

        public void On()
        {
            Console.WriteLine("Switch on the equipment");
            Equipment.PowerOn();   
        }
        public void Off()
        {
            Console.WriteLine("Switch off the equipment");
            Equipment.PowerOff();
        }
    }
}