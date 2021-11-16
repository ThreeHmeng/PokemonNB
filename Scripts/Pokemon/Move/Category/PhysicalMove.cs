using System.Collections;

namespace Pokemon.Move.Category
{
    public class PhysicalMove : Category
    {
        public PhysicalMove()
        {
            CategoryName = "Physical Move";
            
        }
        
        public  new void UseMove(Pokemon myPokemon, Pokemon yourPokemon)
        {
            CalculativeAttack = myPokemon.AttackCurrent1;
            CalculativeDefense = yourPokemon.DefenseCurrent1;
        }
    }
}