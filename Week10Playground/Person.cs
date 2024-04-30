using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Playground
{
    public abstract class Person
    {
        public string Name {get;set;}
        public List<Haki> Skills { get; set; }
        public Tuple<string, string> DevilFruit { get; set; }

        public Person() { }

        public abstract void SetSail();

    }
}
