using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Ivysaur : Pokemon//妙蛙草
    {
        public Ivysaur()
        {
            Number = 2;

            SpeciesName = "Ivysaur";

            Type = new Grass();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 60;
            SpeciesStrength[1] = 62;
            SpeciesStrength[2] = 63;
            SpeciesStrength[3] = 80;
            SpeciesStrength[4] = 80;
            SpeciesStrength[5] = 60;

            ExpSpeed = new Slow();

            CatchRate = 45;
        
            EvolutionLv = 32;

            BasicExperience = 141;
        }

        public new Pokemon Evolution()
        {
            Pokemon newPokemon = new Venusaur();
            newPokemon.DefaultPokemon(Lv1);
            newPokemon.CurrentExp1 = CurrentExp1;
            return newPokemon;
        }

    }
}