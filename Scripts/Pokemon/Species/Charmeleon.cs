using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Charmeleon : Pokemon//火恐龙
    {
        public Charmeleon()
        {
            Number = 5;

            SpeciesName = "Charmeleon";

            Type = new Fire();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 58;
            SpeciesStrength[1] = 64;
            SpeciesStrength[2] = 58;
            SpeciesStrength[3] = 80;
            SpeciesStrength[4] = 65;
            SpeciesStrength[5] = 80;

            ExpSpeed = new Slow();

            CatchRate = 45;
            
            EvolutionLv = 36;

            BasicExperience = 142;
        }

        public new Pokemon Evolution()
        {
            Pokemon newPokemon = new Charizard();
            newPokemon.DefaultPokemon(Lv1);
            newPokemon.CurrentExp1 = CurrentExp1;
            return newPokemon;
        }

    }
}