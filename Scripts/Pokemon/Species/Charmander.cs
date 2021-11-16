using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Charmander : Pokemon//小火龙
    {
        public Charmander()
        {
            Number = 4;

            SpeciesName = "Charmander";

            Type = new Fire();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 39;
            SpeciesStrength[1] = 52;
            SpeciesStrength[2] = 43;
            SpeciesStrength[3] = 60;
            SpeciesStrength[4] = 50;
            SpeciesStrength[5] = 65;

            ExpSpeed = new Slow();

            CatchRate = 45;
            
            EvolutionLv = 16;

            BasicExperience = 65;
        }

        public new Pokemon Evolution()
        {
            Pokemon newPokemon = new Charmeleon();
            newPokemon.DefaultPokemon(Lv1);
            newPokemon.CurrentExp1 = CurrentExp1;
            return newPokemon;
        }
    }
}