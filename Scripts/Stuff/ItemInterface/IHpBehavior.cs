namespace Stuff.ItemInterface
{
    public interface IHpBehavior
    {
        public void ChangeHp();
        public void SetTarget(Pokemon.Pokemon target);

        public Pokemon.Pokemon GetTarget();
    }
}