using System.Collections;

namespace Pokemon.StatusCondition
{
    public class Sleep : StatusCondition//冰冻
    {
        public Sleep()
        {
            StatusConditionName = "Sleep";
        }

        public new void Effect()
        {
            //持续时间2-4回合。处于睡眠状态的宝可梦每次行动后睡眠状态的持续回合就会减少1。
        }
    }
}