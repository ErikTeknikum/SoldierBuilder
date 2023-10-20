using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    internal class Armor
    {
        private string name = string.Empty;
        private int durability;
        private int defence;
        public Armor(string  name, int durability, int defence)
        {
            this.name = name;
            this.durability = durability;
            this.defence = defence;
        }
    }
}