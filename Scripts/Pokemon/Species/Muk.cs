using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Muk : Pokemon//臭臭泥
    {
        public Muk()
        {
            Number = 16;

            SpeciesName = "Muk";

            Type = new Type.Poison();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 105;
            SpeciesStrength[1] = 105;
            SpeciesStrength[2] = 75;
            SpeciesStrength[3] = 65;
            SpeciesStrength[4] = 100;
            SpeciesStrength[5] = 50;

            ExpSpeed = new Fast();;

            CatchRate = 75;
        
            EvolutionLv = 999;

            BasicExperience = 157;
        }
        
    }
}