using UnityEngine;

namespace Pokemon.Move.Category
{
    public class Category
    {
        protected string CategoryName;
        protected int CalculativeAttack;
        protected int CalculativeDefense;

        public string CategoryName1
        {
            get => CategoryName;
            set => CategoryName = value;
        }

        public int CalculativeAttack1
        {
            get => CalculativeAttack;
            set => CalculativeAttack = value;
        }

        public int CalculativeDefense1
        {
            get => CalculativeDefense;
            set => CalculativeDefense = value;
        }
        
    }
}