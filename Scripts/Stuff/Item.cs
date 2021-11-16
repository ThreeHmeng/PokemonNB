using Stuff.ItemInterface;
using UnityEngine;

namespace Stuff
{
    public class Item
    {
        protected IHpBehavior HpBehavior;

        protected IPpBehavior PpBehavior;

        protected IStatusBehavior StatusBehavior;
        
        private int _number = 2;

        private int _cost;

        public IStatusBehavior StatusBehavior1
        {
            get => StatusBehavior;
            set => StatusBehavior = value;
        }

        protected IBuyingBehavior BuyingBehavior;
        

        public IBuyingBehavior BuyingBehavior1
        {
            get => BuyingBehavior;
            set => BuyingBehavior = value;
        }

        public int Cost
        {
            get => _cost;
            set => _cost = value;
        }
        //private Pokemon.Pokemon _target;

        public IHpBehavior HpBehavior1
        {
            get => HpBehavior;
            set => HpBehavior = value;
        }

        // public Pokemon.Pokemon Target
        // {
        //     get => _target;
        //     set => _target = value;
        // }

        public int Number
        {
            get => _number;
            set => _number = value;
        }
        

        public void Use()
        {
            if (_number > 0)
            {
                Debug.Log("Empty");
            }
            else
            {
                this.HpBehavior.ChangeHp();
                this.PpBehavior.PpChange();
                this.StatusBehavior.StatusChange();
                _number--;
            }
        }
    }
}