using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_en_functions
{
    class Skill
    {
        Elements element;
        internal int damage;
        internal int energycost;
        string name = "mewtwo";

        internal Skill()
        {

        }

        internal Skill(Skill copyFrom)
        {
            this.damage = copyFrom.damage;
            this.energycost = copyFrom.energycost;
            this.name = copyFrom.name;
        }

        internal void UseOn(consolemon target, consolemon caster)
        {
            caster.DepleteEnergy(energycost);
            target.TakeDamage(damage);
        }
    }
}
