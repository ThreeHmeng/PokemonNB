using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Pidgey : Pokemon//波波
    {
        public Pidgey()
        {
            Number = 10;

            SpeciesName = "Pidgey";

            Type = new Flying();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 40;
            SpeciesStrength[1] = 45;
            SpeciesStrength[2] = 40;
            SpeciesStrength[3] = 35;
            SpeciesStrength[4] = 35;
            SpeciesStrength[5] = 56;

            ExpSpeed = new Slow();

            CatchRate = 255;
        
            EvolutionLv = 18;

            BasicExperience = 55;
        }

        public new Pokemon Evolution()
        {
            Pokemon newPokemon = new Pidgeotto();
            newPokemon.DefaultPokemon(Lv1);
            newPokemon.CurrentExp1 = CurrentExp1;
            return newPokemon;
        }

    }
}