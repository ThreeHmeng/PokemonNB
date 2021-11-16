namespace Stuff.ItemInterface
{
    public class SmallHpRecover : IHpBehavior
    {
        private Pokemon.Pokemon _target;
        private const int Recover = 10;
        
        public void ChangeHp()
        {
            if (_target.HpCurrent1 + Recover <= _target.HpCurrent1)
            {
                _target.HpCurrent1 += Recover;
            }
            else
            {
                _target.HpCurrent1 = _target.HpDefault1;
            }
        }

        public void SetTarget(Pokemon.Pokemon target)
        {
            this._target = target;
        }

        public Pokemon.Pokemon GetTarget()
        {
            return _target;
        }
        
    }
}