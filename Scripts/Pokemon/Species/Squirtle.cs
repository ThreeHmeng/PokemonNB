using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Squirtle : Pokemon//杰尼龟
    {
        public Squirtle()
        {
            Number = 7;

            SpeciesName = "Squirtle";

            Type = new Water();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 44;
            SpeciesStrength[1] = 48;
            SpeciesStrength[2] = 65;
            SpeciesStrength[3] = 50;
            SpeciesStrength[4] = 64;
            SpeciesStrength[5] = 43;

            ExpSpeed = new Slow();

            CatchRate = 45;
        
            EvolutionLv = 16;

            BasicExperience = 66;
        }

        public new Pokemon Evolution()
        {
            Pokemon newPokemon = new Wartortle();
            newPokemon.DefaultPokemon(Lv1);
            newPokemon.CurrentExp1 = CurrentExp1;
            return newPokemon;
        }

    }
}