using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_en_functions
{
    class Skill
    {
        int damage = 200;
        int energycost = 24;
        string name = "mewtwo";

        internal void UseOn(consolemon target, consolemon caster)
        {
            caster.DepleteEnergy(energycost);
            target.TakeDamage(damage);
        }
    }
}
