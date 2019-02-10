using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClayProject.Models
{
    public class Attack
    {
        private string _name;
        private string _description;
        private decimal _multiplier;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        public decimal Multiplier
        {
            get
            {
                return this._multiplier;
            }
            set
            {
                this._multiplier = value;
            }
        }

        public Attack(string name, string description)
            : this(name, description, 1)
        {
            this._name = name;
            this._description = description;
        }

        public Attack(string name, string description, decimal multiplier)
        {
            this._multiplier = multiplier;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
