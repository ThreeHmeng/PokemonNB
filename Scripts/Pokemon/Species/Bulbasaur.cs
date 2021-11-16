using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Bulbasaur : Pokemon//妙蛙种子
    {
        public Bulbasaur()
        {
            Number = 1;

            SpeciesName = "Bulbasaur";

            Type = new Grass();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 45;
            SpeciesStrength[1] = 49;
            SpeciesStrength[2] = 49;
            SpeciesStrength[3] = 65;
            SpeciesStrength[4] = 65;
            SpeciesStrength[5] = 45;

            ExpSpeed = new Slow();

            CatchRate = 45;

            EvolutionLv = 16;

            BasicExperience = 64;
        }

        public new Pokemon Evolution()
        {
            Pokemon newPokemon = new Ivysaur();
            newPokemon.DefaultPokemon(Lv1);
            newPokemon.CurrentExp1 = CurrentExp1;
            return newPokemon;
        }

    }
}