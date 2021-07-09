using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionEx1
{
    class Granade : IWeapon
    {

        public string name { get; set; }
        public void attackWithMe()
        {
            Console.WriteLine(name + " " + "kil enemies with bomb");
        }
    }
}
