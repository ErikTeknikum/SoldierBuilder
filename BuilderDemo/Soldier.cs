using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    internal class Soldier
    {
        private string name;
        private int health;
        private int age;
        private List<Armor> armors;
        private Weapon weapon;

        public Soldier(string name, int health, int age, List<Armor> armors, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.age = age;
            this.weapon = weapon;
            this.armors = armors;
        }
    }
}