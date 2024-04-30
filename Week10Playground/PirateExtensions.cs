using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Playground
{
    public static class PirateExtensions
    {
        public static string FightPirate(this Pirate yourself, Pirate enemyPirate)
        {
            if (yourself.Bounty > enemyPirate.Bounty) 
            { 
                Console.WriteLine($"{yourself.Name} Defeated {enemyPirate.Name} !");
                //ExtendedFightLogicMethod
                return ($"{yourself.Name} Defeated {enemyPirate.Name} !");
            }
            else if (yourself.Bounty == enemyPirate.Bounty)
            {
                Console.WriteLine($"{enemyPirate.Name} Defeated {yourself.Name} !");
                return ($"{yourself.Name} and {enemyPirate.Name} had a draw!");
            }
            else
            {
                Console.WriteLine($"{enemyPirate.Name} Defeated {yourself.Name} !");
                return ($"{enemyPirate.Name} Defeated {yourself.Name} !");
            }

        }
        public static void SayHi(this Pirate yourself)
        {
            Console.WriteLine($"{yourself.Name} said Hi!");

        }
    }
}