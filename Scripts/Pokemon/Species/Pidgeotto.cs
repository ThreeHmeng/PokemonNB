using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Pidgeotto : Pokemon//比比鸟
    {
        public Pidgeotto()
        {
            Number = 11;

            SpeciesName = "Pidgeotto";

            Type = new Flying();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 63;
            SpeciesStrength[1] = 60;
            SpeciesStrength[2] = 55;
            SpeciesStrength[3] = 50;
            SpeciesStrength[4] = 50;
            SpeciesStrength[5] = 71;

            ExpSpeed = new Slow();;

            CatchRate = 120;
        
            EvolutionLv = 36;

            BasicExperience = 113;
        }

        public new Pokemon Evolution()
        {
            Pokemon newPokemon = new Pidgeot();
            newPokemon.DefaultPokemon(Lv1);
            newPokemon.CurrentExp1 = CurrentExp1;
            return newPokemon;
        }

    }
}