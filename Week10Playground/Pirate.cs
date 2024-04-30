using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Playground
{
    public class Pirate : Person, IPirate
    {
        public new string Name { get; set; }
        public PirateCrew? Crew { get; set; }
        public new List<Haki> Skills { get; set; }
        public new Tuple<string, string> DevilFruit { get; set; }
        public long Bounty { get; set; } = 0;

        public Pirate(string Name, PirateCrew Crew, List<Haki> Skills, Tuple<string, string> DevilFruit, long Bounty = 0L)
        {
            this.Name = Name;
            this.Crew = Crew;
            this.Skills = Skills;
            this.DevilFruit = DevilFruit;
            this.Bounty = Bounty;
        }


        public override void SetSail()
        {
            Console.WriteLine($"{Name} of the {Crew.CrewName} has set sail!");

        }

        public void SetSail(string Island)
        {
            Console.WriteLine($"{Name} of the {Crew.CrewName} has set sail for {Island}!");
        }
    }
}
