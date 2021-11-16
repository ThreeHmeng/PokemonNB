using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move
{
    public class Thunder : Move // 打雷
    {
        public Thunder()
        {
            MoveName = "Thunder";

            Type = new Electric();

            Category = new SpecialMove();

            Pp = 10;

            Power = 120;

            Accuracy = 70;

            EasyToHit = false;
        }
        public new bool SetStatusCondition(Pokemon yourPokemon)
        {
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