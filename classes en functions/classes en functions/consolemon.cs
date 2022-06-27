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

        internal int health = 106;
        internal int energy = 150;
        string name = "mewtwo";


        internal List<Skill> Skills = new List<Skill>();


        internal consolemon()
        {

        }

        
        internal consolemon(consolemon copyFrom)
        {
            this.health = copyFrom.health;
            this.energy = copyFrom.energy;
            this.name = copyFrom.name;

            for (int i = 0; i < copyFrom.Skills.Count; i++)
            {
                Skill copyFromThisSkill = copyFrom.Skills[i];
                Skill copy = new Skill(copyFromThisSkill);

                this.Skills.Add(copy);
            }
        }

        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            energy -= energy;
        }

       
           
    }
    internal class consolemonArena
    {
        public void DoBattle (consolemon a, consolemon b)
        {
            Random rand = new Random();

            while (a.health > 0 || b.health > 0)
            {
                Skill aSkill = a.Skills[rand.Next(a.Skills.Count)];
                aSkill.UseOn(b, a);

                Skill bSkill = b.Skills[rand.Next(b.Skills.Count)];
                bSkill.UseOn(a, b);

                Console.WriteLine(a.health);
                Console.WriteLine(b.health);
            }
        }
    }
    
}
