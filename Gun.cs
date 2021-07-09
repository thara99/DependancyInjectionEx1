using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionEx1
{
    class Gun:IWeapon
    {

        public string name { get; set; }
        public List<Bullet> bullet { get; set; }

        void IWeapon.attackWithMe()
        {
            if (bullet.Count > 0)
            {
                Console.WriteLine(name + " " + "is firering" + " " + bullet[0].name + " " + "enemy shoul die");
                bullet.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("The gun has no bullet");
            }
        }
    }
}
