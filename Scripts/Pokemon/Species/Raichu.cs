using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Raichu : Pokemon//雷丘
    {
        public Raichu()
        {
            Number = 14;

            SpeciesName = "Raichu";

            Type = new Electric();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 60;
            SpeciesStrength[1] = 90;
            SpeciesStrength[2] = 55;
            SpeciesStrength[3] = 90;
            SpeciesStrength[4] = 80;
            SpeciesStrength[5] = 100;

            ExpSpeed = new Fast();

            CatchRate = 75;
        
            EvolutionLv = 999;

            BasicExperience = 122;
        }
        
    }
}