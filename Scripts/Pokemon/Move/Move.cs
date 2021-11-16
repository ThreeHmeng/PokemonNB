using UnityEngine;

namespace Pokemon.Move
{
    public class Move
    {
        protected string MoveName;

        protected Type.Type Type;

        protected Category.Category Category;

        protected int Pp;
        
        protected int Power;
        
        protected int Accuracy;

        protected int Damage;

        protected bool EasyToHit;//1 or 4

        public string MoveName1
        {
            get => MoveName;
            set => MoveName = value;
        }

        public Type.Type Type1
        {
            get => Type;
            set => Type = value;
        }

        public Category.Category Category1
        {
            get => Category;
            set => Category = value;
        }

        public int Pp1
        {
            get => Pp;
            set => Pp = value;
        }

        public int Power1
        {
            get => Power;
            set => Power = value;
        }

        public int Accuracy1
        {
            get => Accuracy;
            set => Accuracy = value;
        }

        public int Damage1
        {
            get => Damage;
            set => Damage = value;
        }

        public bool EasyToHit1
        {
            get => EasyToHit;
            set => EasyToHit = value;
        }

        //Damage

        public double TypeConsistentEffect(Pokemon myPokemon)
        {
            if (myPokemon.Type1.TypeName.Equals(Type.TypeName))
                return 1.5;
            return 1;
        }

        public bool CriticalHit()
        {
            int rd = Random.Range(0, 16);
            if (EasyToHit)
            {
                if (rd < 4)
                {
                    Damage = (int) (Damage * 1.5);
                    return true;//////
                }
            }
            else
            {
                if (rd < 1)
                {
                    Damage = (int) (Damage * 1.5);
                    return true;//////
                }
            }
            return false;
        }

        public void SetDamage(Pokemon myPokemon, Pokemon yourPokemon)
        {
            Damage = (int)(((2 * myPokemon.Lv1 + 10) * Category.CalculativeAttack1 * Power / (Category.CalculativeDefense1 * 250) + 2) 
                     * TypeConsistentEffect(myPokemon) * Type.TypeEffect(yourPokemon.Type1));
        }

        public void PromoteStat(Pokemon myPokemon)
        {
            
        }
        
        public bool SetStatusCondition(Pokemon yourPokemon)
        {
            return false;
        }

        public void UseMove(Pokemon myPokemon, Pokemon yourPokemon)
        {
            
        }
    }
}