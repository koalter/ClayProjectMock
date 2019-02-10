using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClayProject.Models
{
    public class Avatar
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Job { get; set; }
        public decimal HP { get; set; }
        public decimal Damage { get; set; }
        public Stats Stats { get; set; }
        public List<Attack> Attacks { get; set; }

        private Avatar(string name, string job, decimal hp, decimal damage)
        {
            this.Level = 1;
            this.Name = name;
            this.Job = job;
            this.HP = hp;
            this.Damage = damage;
            this.Attacks = new List<Attack>();
        }

        public Avatar()
        {

        }

        public Avatar(string name, string job, decimal hp, decimal damage, int strength, int agility, int intelligence)
            : this(name, job, hp, damage)
        {
            this.Stats = new Stats(strength, agility, intelligence);
        }
        
        public Avatar(string name, string job, decimal hp, decimal damage, Stats stats)
            : this(name, job, hp, damage)
        {
            this.Stats = stats;
        }
    }
}
