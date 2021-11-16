using Pokemon.Move.Category;
using Pokemon.Type;

namespace Pokemon.Move
{
    public class SolarBeam : Move//日光束
    {
        public SolarBeam()
        {
            MoveName = "SolarBeam";

            Type = new Normal();

            Category = new SpecialMove();

            Pp = 10;

            Power = 120;

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