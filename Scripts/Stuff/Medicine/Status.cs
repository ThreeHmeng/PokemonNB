using Pokemon.StatusCondition;
using Stuff.ItemInterface;

namespace Stuff.Medicine
{
    public class Status : Medicine
    {
        public Status()
        {
            this.HpBehavior = new NoHpRecover();
            this.PpBehavior = new NoPpRecover();
            this.StatusBehavior = new ClearStatus();
            Cost = 20;
        }
    }
}