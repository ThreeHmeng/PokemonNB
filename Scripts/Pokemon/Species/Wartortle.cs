using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Wartortle : Pokemon//卡咪龟
    {
        public Wartortle()
        {
            Number = 8;

            SpeciesName = "Wartortle";

            Type = new Water();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 59;
            SpeciesStrength[1] = 63;
            SpeciesStrength[2] = 80;
            SpeciesStrength[3] = 65;
            SpeciesStrength[4] = 80;
            SpeciesStrength[5] = 58;

            ExpSpeed = new Slow();

            CatchRate = 45;
        
            EvolutionLv = 36;

            BasicExperience = 143;
        }

        public new Pokemon Evolution()
        {
            Pokemon newPokemon = new Squirtle();
            newPokemon.DefaultPokemon(Lv1);
            newPokemon.CurrentExp1 = CurrentExp1;
            return newPokemon;
        }

    }
}