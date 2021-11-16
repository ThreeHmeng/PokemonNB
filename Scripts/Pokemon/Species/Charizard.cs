using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Charizard : Pokemon//喷火龙
    {
        public Charizard()
        {
            Number = 6;

            SpeciesName = "Charizard";

            Type = new Fire();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 78;
            SpeciesStrength[1] = 84;
            SpeciesStrength[2] = 78;
            SpeciesStrength[3] = 109;
            SpeciesStrength[4] = 85;
            SpeciesStrength[5] = 100;

            ExpSpeed = new Slow();

            CatchRate = 45;
       
            EvolutionLv = 999;

            BasicExperience = 209;
        }

    }
}