using UnityEngine;
using System;
using System.Collections;

namespace Pokemon.StatusCondition
{
    public class StatusCondition
    {
        protected string StatusConditionName;

        public string StatusConditionName1
        {
            get => StatusConditionName;
            set => StatusConditionName = value;
        }

        public void Effect()
        {
            //处于麻痹状态的宝可梦速度会减半，并且在使用招式时有25%几率无法行动。
        }
    }

    
    // public class LoadStatusConditionModule
    // {
    //     private StatusCondition _normal = new StatusCondition("Normal");
    //     private StatusCondition _burn = new StatusCondition("Burn");
    //     private StatusCondition _freeze = new StatusCondition("Freeze");
    //     private StatusCondition _paralysis = new StatusCondition("Paralysis");
    //     private StatusCondition _poison = new StatusCondition("Poison");
    //     private StatusCondition _badlyPoison = new StatusCondition("Badly Poison");
    //     private StatusCondition _sleep = new StatusCondition("Sleep");
    //     
    //     public LoadStatusConditionModule(){}
    //
    // }
}