using System.Collections;

namespace Pokemon.StatusCondition
{
    public class Poison : StatusCondition//冰冻
    {
        public Poison()
        {
            StatusConditionName = "Poison";
        }

        public new void Effect()
        {
            //处于中毒状态的宝可梦会在回合结束时损失最大HP的1⁄8。
        }
    }
}