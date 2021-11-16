namespace Stuff.ItemInterface
{
    public class SmallPpRecover : IPpBehavior
    {
        private Pokemon.Pokemon _target;
        private const int Recover = 5;
        public void PpChange()
        {
            for (int i = 0; i < 4; i++)
            {
                if (_target.CurrentMovePp1[i] <= _target.CurrentMoves1[i].Pp1)
                {
                    _target.CurrentMovePp1[i] += Recover;
                }
                else
                {
                    _target.CurrentMovePp1[i] = _target.CurrentMoves1[i].Pp1;
                }
            }
        }

        public void SetTarget(Pokemon.Pokemon target)
        {
            _target = target;
        }

        public Pokemon.Pokemon GetTarget()
        {
            return _target;
        }
    }
}