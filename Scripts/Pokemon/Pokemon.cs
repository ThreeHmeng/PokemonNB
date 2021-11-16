using System;
using System.Collections;
using System.Collections.Generic;
using Pokemon.Move;
using Pokemon.Nature;
using Pokemon.Species;
using Pokemon.StatusCondition;
using Pokemon.Type;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Pokemon
{
    public class Pokemon 
    {
        //Stat能力
        
        protected int HpCurrent;

        protected int HpDefault;
        
        protected int AttackCurrent;

        protected int AttackDefault;

        protected int DefenseCurrent;
        
        protected int DefenseDefault;
        
        protected int SpecialAttackCurrent;

        protected int SpecialAttackDefault;
        
        protected int SpecialDefenseCurrent;

        protected int SpecialDefenseDefault;

        protected int SpeedCurrent;

        protected int SpeedDefault;

        protected double AccuracyRate;//命中率

        protected double EvasionRate;//闪避率
        
        //Species种族
        
        protected int Number;
        
        protected string SpeciesName;

        protected Type.Type Type;//属性

        protected ArrayList AllMove;//这个宝可梦能学的技能列表/////////////////////////////////////////////////////////////////
        
        protected int[] SpeciesStrength = new int[6];//种族值，血攻防特特速
        
        protected ExpSpeed.ExpSpeed ExpSpeed;//经验累积速度
        
        protected int BasicExperience;//基础经验值

        protected int CatchRate;//捕获率

        //Individual个体

        protected string IndividualName;

        protected Nature.Nature Nature;//性格
        
        protected int Iv;//个体值0-31

        protected int Lv;

        protected int CurrentExp;//当前经验

        protected int ExpNeed;//到下一级所需经验

        protected Move.Move[] CurrentMoves = new Move.Move[4];//size4////////////////////////////////////////////////////////

        protected int[] CurrentMovePp = new int[4];//size4

        protected Move.Move CurrentUse;//当前使用的技能

        protected StatusCondition.StatusCondition StatusCondition;//异常状态
        
        protected int EvolutionLv;

        //get set
        
        public int HpCurrent1
        {
            get => HpCurrent;
            set => HpCurrent = value;
        }

        public int HpDefault1
        {
            get => HpDefault;
            set => HpDefault = value;
        }

        public int AttackCurrent1
        {
            get => AttackCurrent;
            set => AttackCurrent = value;
        }

        public int AttackDefault1
        {
            get => AttackDefault;
            set => AttackDefault = value;
        }

        public int DefenseCurrent1
        {
            get => DefenseCurrent;
            set => DefenseCurrent = value;
        }

        public int DefenseDefault1
        {
            get => DefenseDefault;
            set => DefenseDefault = value;
        }

        public int SpecialAttackCurrent1
        {
            get => SpecialAttackCurrent;
            set => SpecialAttackCurrent = value;
        }

        public int SpecialAttackDefault1
        {
            get => SpecialAttackDefault;
            set => SpecialAttackDefault = value;
        }

        public int SpecialDefenseCurrent1
        {
            get => SpecialDefenseCurrent;
            set => SpecialDefenseCurrent = value;
        }

        public int SpecialDefenseDefault1
        {
            get => SpecialDefenseDefault;
            set => SpecialDefenseDefault = value;
        }

        public int SpeedCurrent1
        {
            get => SpeedCurrent;
            set => SpeedCurrent = value;
        }

        public int SpeedDefault1
        {
            get => SpeedDefault;
            set => SpeedDefault = value;
        }

        public double AccuracyRate1
        {
            get => AccuracyRate;
            set => AccuracyRate = value;
        }

        public double EvasionRate1
        {
            get => EvasionRate;
            set => EvasionRate = value;
        }

        public int Number1
        {
            get => Number;
            set => Number = value;
        }

        public string SpeciesName1
        {
            get => SpeciesName;
            set => SpeciesName = value;
        }
        

        public ArrayList AllMove1
        {
            get => AllMove;
            set => AllMove = value;
        }

        public int[] SpeciesStrength1
        {
            get => SpeciesStrength;
            set => SpeciesStrength = value;
        }

        public Type.Type Type1
        {
            get => Type;
            set => Type = value;
        }

        public ExpSpeed.ExpSpeed ExpSpeed1
        {
            get => ExpSpeed;
            set => ExpSpeed = value;
        }

        public int CatchRate1
        {
            get => CatchRate;
            set => CatchRate = value;
        }

        public string IndividualName1
        {
            get => IndividualName;
            set => IndividualName = value;
        }

        public Nature.Nature Nature1
        {
            get => Nature;
            set => Nature = value;
        }

        public int Iv1
        {
            get => Iv;
            set => Iv = value;
        }

        public int Lv1
        {
            get => Lv;
            set => Lv = value;
        }

        public int CurrentExp1
        {
            get => CurrentExp;
            set => CurrentExp = value;
        }

        public int ExpNeed1
        {
            get => ExpNeed;
            set => ExpNeed = value;
        }

        public Move.Move[] CurrentMoves1
        {
            get => CurrentMoves;
            set => CurrentMoves = value;
        }

        public Move.Move CurrentUse1
        {
            get => CurrentUse;
            set => CurrentUse = value;
        }

        public int[] CurrentMovePp1
        {
            get => CurrentMovePp;
            set => CurrentMovePp = value;
        }

        public StatusCondition.StatusCondition StatusCondition1
        {
            get => StatusCondition;
            set => StatusCondition = value;
        }

        public int BasicExperience1
        {
            get => BasicExperience;
            set => BasicExperience = value;
        }

        public int EvolutionLv1
        {
            get => EvolutionLv;
            set => EvolutionLv = value;
        }


        public void DefaultPokemon(int lv)
        {
            HpCalculate();
            AttackCalculate();
            DefenseCalculate();
            SpecialAttackCalculate();
            SpecialDefenseCalculate();
            SpeedCalculate();
            HpCurrent = HpDefault;
            AttackCurrent = AttackDefault;
            DefenseCurrent = DefenseDefault;
            SpecialAttackCurrent = SpecialAttackDefault;
            SpecialDefenseCurrent = SpecialDefenseDefault;
            SpeedCurrent = SpeedDefault;
            AccuracyRate = 1;
            EvasionRate = 1;
        }

        public void InitialPokemon(int lv)
        {
            LoadNatureModule natureModule = new LoadNatureModule();
            natureModule.SetNatureRandomly(this);
            Iv = Random.Range(0, 32);
            Lv = lv;
            DefaultPokemon(lv);
            CurrentExp = 0;
            ExpNeed = ExpSpeed.ExpAccumulate[lv];
            setMove(lv);
            CurrentMovePp[0] = 1;
            CurrentMovePp[1] = 2;////
            CurrentMovePp[2] = 5;
            CurrentMovePp[3] = 8;////
            StatusCondition = new StatusCondition.Normal();
        }


        public void setMove(int lv)
        {
            if (lv < 10)
            {
                CurrentMoves[0] = new Growl();
            }else if (lv < 19)
            {
                CurrentMoves[0] = new Growl();
                CurrentMoves[1] = new Scratch();
            }
            else if (lv < 35)
            {
                CurrentMoves[0] = new Growl();
                CurrentMoves[1] = new Scratch();
                CurrentMoves[2] = new Thunder();
            }
            else
            {
                CurrentMoves[0] = new Growl();
                CurrentMoves[1] = new Scratch();
                CurrentMoves[2] = new Thunder();
                CurrentMoves[3] = new SolarBeam();
            }
        }

        
        public Pokemon SetPokemonRandomly(int lv)/////
        {
            ArrayList allPokemon = new ArrayList();
            allPokemon.Add(new Species.Raichu());
            allPokemon.Add(new Species.Bulbasaur());
            allPokemon.Add(new Species.Charmeleon());
            allPokemon.Add(new Species.Pikachu());
            Pokemon pokemon = (Pokemon)allPokemon[Random.Range(0, 4)];
            pokemon.InitialPokemon(lv);
            return pokemon;
        }
        
        //战斗结算
        public void Settlement(int experience)
        {
            CurrentExp += experience;
            Upgrade();
            HpCurrent = HpDefault;
            AttackCurrent = AttackDefault;
            DefenseCurrent = DefenseDefault;
            SpecialAttackCurrent = SpecialAttackDefault;
            SpecialDefenseCurrent = SpecialDefenseDefault;
            SpeedCurrent = SpeedDefault;
            AccuracyRate = 1;
            EvasionRate = 1;
        }
        
        
        public void Upgrade()
        {
            if (CurrentExp >= ExpNeed)
            {
                Lv++;
                HpCalculate();
                AttackCalculate();
                DefenseCalculate();
                SpecialAttackCalculate();
                SpecialDefenseCalculate();
                SpeedCalculate();
                //HpCurrent = HpDefault;
                CurrentExp -= ExpNeed;
                ExpNeed = ExpSpeed.ExpAccumulate[Lv] - ExpSpeed.ExpAccumulate[Lv - 1];
                if (Lv >= EvolutionLv)
                    Evolution();
            }
        }

        public Pokemon Evolution()
        {
            return null;
        }


        public void HpCalculate()
        {
            HpDefault = ((SpeciesStrength[0] * 2 + Iv) * Lv) / 100 + 10 + Lv;
        }

        public void AttackCalculate()
        {
            AttackDefault = (int)((((SpeciesStrength[1] * 2 + Iv) * Lv) / 100 + 5) * Nature.AttackCorrection);
        }

        public void DefenseCalculate()
        {
            DefenseDefault = (int)((((SpeciesStrength[2] * 2 + Iv) * Lv) / 100 + 5) * Nature.DefenseCorrection);
        }

        public void SpecialAttackCalculate()
        {
            SpecialAttackDefault = (int)((((SpeciesStrength[3] * 2 + Iv) * Lv) / 100 + 5) * Nature.SpecialAttackCorrection);
        }
        
        public void SpecialDefenseCalculate()
        {
            SpecialDefenseDefault = (int)((((SpeciesStrength[4] * 2 + Iv) * Lv) / 100 + 5) * Nature.SpecialDefenseCorrection);
        }

        public void SpeedCalculate()
        {
            SpeedDefault = (int)((((SpeciesStrength[1] * 2 + Iv) * Lv) / 100 + 5) * Nature.SpeedCorrection);
        }


        // //战前准备
        // public void SetMove(Move.Move move, int num)
        // {
        //     if (!IsMoveSet(move))
        //     {
        //         CurrentMoves[num] = move;
        //         CurrentMovePp[num] = move.Pp1;
        //     }
        // }
        //
        // public bool IsMoveSet(Move.Move move)
        // {
        //     for (int i = 0; i < 4; i++)
        //     {
        //         if (CurrentMoves[i] == null)
        //             continue;
        //         if (CurrentMoves[i].MoveName1.Equals(move.MoveName1))
        //             return true;
        //     }
        //     return false;
        // }



        //战斗中
        public void UseMove(int num)//设置使用的技能
        {
            CurrentUse = CurrentMoves[num];
        }

        
    }
}
