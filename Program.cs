using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace DependancyInjectionEx1
{
    class Program
    {
        static void Main(string[] args)
        {

            HeroThatOnlyUseSwards hero1 = new HeroThatOnlyUseSwards { name = "ultraman" };
            hero1.attack();

            Console.WriteLine();

            HeroThatCanUseAnyWeapon hero2 = new HeroThatCanUseAnyWeapon { name = "rambo", myWeapon = new Sword { swordName = "excalibure ultra pro max" } };
            hero2.attack();

            Console.WriteLine();

            HeroThatCanUseAnyWeapon hero3 = new HeroThatCanUseAnyWeapon { name = "api thamai hodatama kare", myWeapon = new Granade { name = "c11" } };
            hero3.attack();

            Console.WriteLine();

            HeroThatCanUseAnyWeapon hero4 = new HeroThatCanUseAnyWeapon
            {
                name = "Nero",
                myWeapon = new Gun
                {
                    name = "golden gun",
                    bullet = new List<Bullet>
            {
                new Bullet{name = "silver slug",gramsOfpowder = 10},
                new Bullet{name = "golden slug",gramsOfpowder = 15},
                new Bullet{name = "maria slug",gramsOfpowder = 40},
                new Bullet{name = "jhonnie slug",gramsOfpowder = 05},
            }
                }
            };
            hero4.attack();

            hero4.attack();

            hero4.attack();

            hero4.attack();

            hero4.attack();

            hero4.attack();

            Console.WriteLine();

            ServiceCollection services = new ServiceCollection();
            services.AddTransient<IWeapon, Gun>(s => new Gun
            {
                name = "golden gun",
                bullet = new List<Bullet>
            {
                new Bullet{name = "silver slug",gramsOfpowder = 10},
                new Bullet{name = "golden slug",gramsOfpowder = 15},
                new Bullet{name = "maria slug",gramsOfpowder = 40},
                new Bullet{name = "jhonnie slug",gramsOfpowder = 05},
            }
            });
            services.AddTransient<IHero, HeroThatCanUseAnyWeapon>(hero => new HeroThatCanUseAnyWeapon { name = "jony engish", myWeapon = hero.GetService<IWeapon>() });
            ServiceProvider provider = services.BuildServiceProvider();
            var hero5 = provider.GetService<IHero>();
            hero5.attack();
            hero5.attack();
            hero5.attack();
            hero5.attack();
            hero5.attack();
            hero5.attack();


        }
    }
}
