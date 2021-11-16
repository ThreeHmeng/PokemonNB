using System.Collections;

namespace Pokemon.StatusCondition
{
    public class Fire : StatusCondition//灼伤
    {
        public Fire()
        {
            StatusConditionName = "Fire";
        }

        public new void Effect()
        {
            //处于灼伤状态的宝可梦使用非固定伤害类物理招式的伤害会减半，并在回合结束时损失最大HP的1⁄16。
        }
    }
}