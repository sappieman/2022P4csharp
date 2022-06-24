using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_en_functions
{

    internal enum colours
    {
        Green,
        Blue,
        Yellow,
        red,

    }

    internal enum Elements
    {
        Water,
        Earth,
        Fire,
        Air,
    }
    class consolemon
    {
        Elements Weakness;

        int health = 106;
        int energy = 150;
        string name = "mewtwo";

        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            energy -= energy;
        }

        internal List<Skill> skills = new List<Skill>();
           
    }

    
}
