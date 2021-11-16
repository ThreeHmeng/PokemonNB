using Stuff.ItemInterface;

namespace Stuff.Medicine
{
    public class PpSmall: Medicine
    {

        public PpSmall()
        {
            this.HpBehavior = new NoHpRecover();
            this.PpBehavior = new SmallPpRecover();
            this.StatusBehavior = new NoStatusChange();
            //BuyingBehavior = new CanBuy();
            Cost = 5;
        }
    }
}