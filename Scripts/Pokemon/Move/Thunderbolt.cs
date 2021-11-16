using Pokemon.Move;
using Pokemon.Move.Category;
using Pokemon.Type;
using UnityEngine;

namespace Pokemon.Move
{
    public class Thunderbolt : Move //十万伏特
    {
        public Thunderbolt()
        {
            MoveName = "Thunderbolt";

            Type = new Electric();

            Category = new SpecialMove();

            Pp = 15;

            Power = 95;

            Accuracy = 100;

            EasyToHit = false;
        }

        public new bool SetStatusCondition(Pokemon yourPokemon)
        {
            int rd = Random.Range(0, 10);
            if (rd < 1)
            {
                yourPokemon.StatusCondition1 = new StatusCondition.Paralysis();
                return true; //////
            }
            return false;
        }

        public new void UseMove(Pokemon myPokemon, Pokemon yourPokemon)
        {
            SetDamage(myPokemon, yourPokemon);
            CriticalHit();
            SetStatusCondition(yourPokemon);
        }

    }

}