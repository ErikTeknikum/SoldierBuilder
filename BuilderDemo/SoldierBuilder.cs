using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    internal class SoldierBuilder
    {
        private string name = string.Empty;
        private int health;
        private int age;
        private List<Armor> armors = new List<Armor>();
        
        private Weapon weapon;

        public SoldierBuilder Name(string name)
        {
            this.name = name;
            return this;
        }
        public SoldierBuilder Health(int health)
        {
            this.health = health;
            return this;
        }
        public SoldierBuilder Age(int age)
        {
            this.age = age;
            return this;
        }
        public SoldierBuilder Armors(List<Armor> armors)
        {
            this.armors = armors;
            return this;
        }

        public SoldierBuilder AddArmor(Armor armor)
        {
            armors.Add(armor);
            return this;
        }
        public SoldierBuilder Weapons(Weapon weapon)
        {
            this.weapon = weapon;
            return this;
        }
        public Soldier Build()
        {
            return new Soldier(name, health, age, armors, weapon);
        }
    }
}