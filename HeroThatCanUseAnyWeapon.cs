using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionEx1
{
    class HeroThatCanUseAnyWeapon:IHero
    {

        public string name { get; set; }

        public IWeapon myWeapon { get; set; }

        public void attack()
        {
            Console.WriteLine(name + " " + "prepare for attack");
            myWeapon.attackWithMe();
        }
    }
}
