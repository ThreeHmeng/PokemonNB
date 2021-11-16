using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Venusaur : Pokemon//妙蛙花
    {
        public Venusaur()
        {
            Number = 3;

            SpeciesName = "Venusaur";

            Type = new Grass();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 80;
            SpeciesStrength[1] = 82;
            SpeciesStrength[2] = 83;
            SpeciesStrength[3] = 100;
            SpeciesStrength[4] = 100;
            SpeciesStrength[5] = 80;

            ExpSpeed = new Slow();

            CatchRate = 45;
        
            
            EvolutionLv = 999;

            BasicExperience = 208;
        }
        
    }
}