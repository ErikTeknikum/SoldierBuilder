using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuilderDemo
{
    internal class Weapon
    {
        private string name;
        private int durability;
        private int strength;
        private double weight;
        public Weapon(int durability, int strength, double weight, string name)
        {
            this.name = name;
            this.durability = durability;
            this.strength = strength;
            this.weight = weight;
        }
    }
}