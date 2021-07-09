using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionEx1
{
    class Sword:IWeapon
    {

        public string swordName { get; set; }

        public void attackWithMe()
        {
            Console.WriteLine(swordName +" " +  "kill all enemies");
        }
    }
}
