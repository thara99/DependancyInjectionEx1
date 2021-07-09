using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionEx1
{
    class HeroThatOnlyUseSwards:IHero
    {

        public string name { get; set; }

        public void attack()
        {
            Sword sword = new Sword { swordName = "excalibure" };
            Console.WriteLine(name +" " +  "prepare for battle with swoard");
            sword.attackWithMe();
        }

    }
}
