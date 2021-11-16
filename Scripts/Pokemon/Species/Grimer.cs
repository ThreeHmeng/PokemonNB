using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Grimer : Pokemon//臭泥
    {
        public Grimer()
        {
            Number = 15;

            SpeciesName = "Grimer";

            Type = new Type.Poison();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 80;
            SpeciesStrength[1] = 80;
            SpeciesStrength[2] = 50;
            SpeciesStrength[3] = 40;
            SpeciesStrength[4] = 50;
            SpeciesStrength[5] = 25;

            ExpSpeed = new Fast();

            CatchRate = 190;
        
            EvolutionLv = 38;

            BasicExperience = 90;
        }

        public new Pokemon Evolution()
        {
            Pokemon newPokemon = new Muk();
            newPokemon.DefaultPokemon(Lv1);
            newPokemon.CurrentExp1 = CurrentExp1;
            return newPokemon;
        }

    }
}