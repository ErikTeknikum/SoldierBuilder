using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    internal class ArmorBuilder
    {
        private string name = string.Empty;
        private int durability;
        private int defence;
        private bool pierceResistance = false;
        private bool slashResistance = false;

        public ArmorBuilder Name(string name)
        {
            this.name = name;
            return this;
        }
        public ArmorBuilder Durability(int durability)
        {
            this.durability = durability;
            return this;
        }
        public ArmorBuilder Defence(int defence)
        {
            this.defence = defence;
            return this;
        }
        public ArmorBuilder PierceResistance(bool pierceResistance)
        {
            this.pierceResistance = pierceResistance;
            return this;
        }
        public ArmorBuilder SlashResistance(bool slashResistance)
        {
            this.slashResistance = slashResistance;
            return this;
        }
        public Armor Build()
        {
            return new Armor(name, durability, defence);
        }
    }
}