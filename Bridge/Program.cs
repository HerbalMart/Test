using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bridge.Interfaces;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //We have some electrical equipments, say Fan, Light etc.
            //So, lets create them first.

            IElectricalEquipment fan = new Fan();
            IElectricalEquipment light = new Light();

            //We also have some switches. Lets create them too.

            Switch fancySwitch = new FancySwitch();
            Switch normalSwitch = new NormalSwitch();

            //Lets connect the Fan to the fancy switch

            fancySwitch.Equipment = fan;

            //As the switch now has an equipment (Fan),
            //so switching on or off should 
            //turn on or off the electrical equipment  

            fancySwitch.On(); //It should turn on the Fan. 

            //so, inside the On() method of Switch,  
            //we must turn on the electrical equipment.

            //It should turn off the Fan. So, inside the On() method of  
            fancySwitch.Off();
            //Switch, we must turn off the electrical equipment

            //Now, lets plug the light to the fancy switch

            fancySwitch.Equipment = light;
            fancySwitch.On(); //It should turn on the Light now
            fancySwitch.Off(); //It should be turn off the Light now
        }
    }
}
