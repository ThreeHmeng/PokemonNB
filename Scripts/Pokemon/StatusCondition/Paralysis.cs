using System.Collections;

namespace Pokemon.StatusCondition
{
    public class Paralysis : StatusCondition//麻痹
    {
        public Paralysis()
        {
            StatusConditionName = "Paralysis";
        }

        public new void Effect()
        {
            //处于麻痹状态的宝可梦速度会减半，并且在使用招式时有25%几率无法行动。
        }
    }
}