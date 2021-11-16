namespace Stuff.ItemInterface
{
    public interface IStatusBehavior
    {
        public void StatusChange();
        
        public void SetTarget(Pokemon.Pokemon target);

        public Pokemon.Pokemon GetTarget();
    }
}