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
        int damage = 200;
        int energycost = 24;
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
