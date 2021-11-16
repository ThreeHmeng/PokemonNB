using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Pokemon.Species
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            Number = 13;

            SpeciesName = "Pikachu";

            Type = new Electric();

            ArrayList AllMove; //这个宝可梦能学的技能列表

            SpeciesStrength[0] = 35;
            SpeciesStrength[1] = 55;
            SpeciesStrength[2] = 30;
            SpeciesStrength[3] = 50;
            SpeciesStrength[4] = 40;
            SpeciesStrength[5] = 90;

            ExpSpeed = new Fast();;

            CatchRate = 190;
        
            EvolutionLv = 38;

            BasicExperience = 82;
        }

        public new Pokemon Evolution()
        {
            Pokemon newPokemon = new Raichu();
            newPokemon.DefaultPokemon(Lv1);
            newPokemon.CurrentExp1 = CurrentExp1;
            return newPokemon;
        }

    }
}