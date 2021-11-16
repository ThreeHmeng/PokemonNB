using System.Collections;

namespace Pokemon.Move.Category
{
    public class SpecialMove : Category
    {
        public SpecialMove()
        {
            CategoryName = "Special Move";
        }
        
        public  new void UseMove(Pokemon myPokemon, Pokemon yourPokemon)
        {
            CalculativeAttack = myPokemon.SpecialAttackCurrent1;
            CalculativeDefense = yourPokemon.SpecialDefenseCurrent1;
        }
    }
}