using System;
using Stuff.ItemInterface;
using UnityEngine;

namespace Stuff.Medicine
{
    using Pokemon;
    public abstract class Medicine :Item
    {
        
        protected Player.Player Player;
        
        protected Pokemon Target;


        

        public Player.Player Player1
        {
            get => Player;
            set => Player = value;
        }

        public void SetTarget(Pokemon target)
        {
            this.Target = target;
            this.HpBehavior.SetTarget(target);
            this.PpBehavior.SetTarget(target);
            this.StatusBehavior.SetTarget(target);
        }

    }
}