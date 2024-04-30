using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Playground
{
    public class PirateCrew
    {
        public string CrewName { get; set; }
        private int NumberOfMembers { get; set; }
        public List<Pirate> Members { get; set; }

        public PirateCrew(string CrewName, int NumberOfMembers, List<Pirate> Members)
        {
            this.CrewName = CrewName;
            this.NumberOfMembers = NumberOfMembers;
            this.Members = Members.Count > 0 ? Members : new List<Pirate>();
        }

    }
}
