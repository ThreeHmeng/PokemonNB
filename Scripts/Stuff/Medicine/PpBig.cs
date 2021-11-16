using Stuff.ItemInterface;

namespace Stuff.Medicine
{
    public class PpBig : Medicine
    {
        public PpBig()
        {
            this.HpBehavior = new NoHpRecover();
            this.PpBehavior = new BigPpRecover();
            this.StatusBehavior = new NoStatusChange();
            //BuyingBehavior = new CanBuy();
            Cost = 25;
        }
    }
}