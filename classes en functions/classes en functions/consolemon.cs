using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_en_functions
{
    class consolemon
    {
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
    }

}
