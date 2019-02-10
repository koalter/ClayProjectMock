using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClayProject.Models
{
    public class Stats
    {
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }

        public Stats(int strength, int agility, int intelligence)
        {
            this.Strength = strength;
            this.Agility = agility;
            this.Intelligence = intelligence;
        }
    }
}
