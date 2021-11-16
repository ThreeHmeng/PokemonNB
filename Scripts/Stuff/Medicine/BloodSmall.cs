using System;
using Stuff.ItemInterface;
using UnityEngine;

namespace Stuff.Medicine
{
    public class BloodSmall : Medicine//10hp
    {
        public BloodSmall()
        {
            this.HpBehavior = new SmallHpRecover();
            this.PpBehavior = new NoPpRecover();
            this.StatusBehavior = new NoStatusChange();
            //BuyingBehavior = new CanBuy();
            Cost = 5;
        }
        
    }
}