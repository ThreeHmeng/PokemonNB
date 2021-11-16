using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Pidgeot : Pokemon//大比鸟
    {
        public Pidgeot()
        {
            Number = 12;

            SpeciesName = "Pidgeot";

            Type = new Flying();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 83;
            SpeciesStrength[1] = 80;
            SpeciesStrength[2] = 75;
            SpeciesStrength[3] = 70;
            SpeciesStrength[4] = 70;
            SpeciesStrength[5] = 91;

            ExpSpeed = new Slow();;

            CatchRate = 45;
        
            EvolutionLv = 999;

            BasicExperience = 172;
        }

    }
}