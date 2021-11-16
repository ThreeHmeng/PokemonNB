using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move
{
    public class Scratch : Move
    {
        public Scratch()
        {
            MoveName = "Scratch";

            Type = new Normal();

            Category = new PhysicalMove();

            Pp = 35;

            Power = 40;

            Accuracy = 100;

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