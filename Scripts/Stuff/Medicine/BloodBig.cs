using Stuff.ItemInterface;

namespace Stuff.Medicine
{
    public class BloodBig : Medicine//30hp
    {
        public BloodBig()
        {
            this.HpBehavior = new BigHpRecover();
            this.PpBehavior = new NoPpRecover();
            this.StatusBehavior = new NoStatusChange();
            Cost = 20;
        }
        
    }
}