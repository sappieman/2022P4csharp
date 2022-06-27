using System;

namespace classes_en_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            consolemon Henk = new consolemon();
            consolemon Walt = new consolemon();

            Skill IceBeam = new Skill();
            Skill ThunderBolt = new Skill();
            Skill Psychic = new Skill();
            Skill FocusBlast = new Skill();

            Henk.Skills.Add(IceBeam);
            Henk.Skills.Add(FocusBlast);

            Walt.Skills.Add(ThunderBolt);
            Walt.Skills.Add(Psychic);

            IceBeam.damage = 5;
            IceBeam.energycost = 5;
            ThunderBolt.damage = 8;
            ThunderBolt.energycost = 4;
            Psychic.damage = 12;
            Psychic.energycost = 10;
            FocusBlast.damage = 12;
            FocusBlast.energycost = 9;

            consolemon a = Henk;
            consolemon b = Walt;

            consolemonArena consolemonArena = new consolemonArena();
            consolemonArena.DoBattle(a, b);


        }
    }
}
