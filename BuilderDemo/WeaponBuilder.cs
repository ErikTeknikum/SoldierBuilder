using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    internal class WeaponBuilder
    {
        private string name = string.Empty;
        private int durability;
        private int strength;
        private double weight;


        public WeaponBuilder Durability(int durability)
        {
            this.durability = durability;
            return this;
        }
        public WeaponBuilder Strength(int strength)
        {
            this.strength = strength;
            return this;
        }
        public WeaponBuilder Weight(double weight)
        {
            this.weight = weight;
            return this;
        }
        public WeaponBuilder Name(string name)
        {
            this.name = name;
            return this;
        }

        public Weapon Build()
        {
            return new Weapon(durability, strength, weight, name);
        }
    }
}