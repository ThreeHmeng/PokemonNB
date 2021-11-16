using System.Collections.Generic;
using Pokemon.ExpSpeed;
using Pokemon.Species;
using UnityEngine;

namespace Battle
{
    public class Battle
    {
        protected InFight Me;
        
        protected InFight You;

        protected InFight CurrentPlayer;

        protected int Round;//回合数

        protected int IsMe;


        public InFight Me1
        {
            get => Me;
            set => Me = value;
        }

        public InFight You1
        {
            get => You;
            set => You = value;
        }

        public InFight CurrentPlayer1
        {
            get => CurrentPlayer;
            set => CurrentPlayer = value;
        }

        public int Round1
        {
            get => Round;
            set => Round = value;
        }

        public int IsMe1
        {
            get => IsMe;
            set => IsMe = value;
        }
        

        public void SetCurrentPokemonList(InFight player, int current, int pack)
        {
            player.CurrentPokemonList[current] = player.PokemonPack[pack];
        }

        public void SetCurrentPokemon(InFight currentPlayer)
        {
            currentPlayer.CurrentPokemon = currentPlayer.CurrentPokemonList[currentPlayer.Death];
        }

        public void Fight(int num)
        {
            CurrentPlayer.CurrentPokemon.UseMove(num);
            CurrentPlayer.CurrentPokemon.CurrentMovePp1[num]--;
        }

        public void Bag(int num)
        {
            CurrentPlayer.ItemPack[num].Use();
            CurrentPlayer.ItemNum[num]--;
        }
        
        public void ChangePlayer()
        {
            if (Round == 0)
            {
                if (Me.CurrentPokemon.SpeedCurrent1 > You.CurrentPokemon.SpeedCurrent1)
                    IsMe = -1;
                else if (Me.CurrentPokemon.SpeedCurrent1 < You.CurrentPokemon.SpeedCurrent1)
                    IsMe = 1;
                else
                {
                    int rd = Random.Range(0, 2);
                    if (rd == 0)
                        IsMe = -1;
                    else
                        IsMe = 1;
                }
            }
            
            IsMe = -IsMe;
            if (IsMe == 1)
                CurrentPlayer = Me;
            else
                CurrentPlayer = You;
        }

        public void RoundEnd()
        {
            if (Me.CurrentPokemon.HpCurrent1 <= 0)
            {
                Me.Death++;
                if (Me.Death == 3)
                {
                    BattleEnd(You, Me);
                }
                else
                {
                    SetCurrentPokemon(Me);
                }
            }
            if (You.CurrentPokemon.HpCurrent1 <= 0)
            {
                You.Death++;
                if (You.Death == 3)
                {
                    BattleEnd(Me, You);
                }
                else
                {
                    SetCurrentPokemon(You);
                }
            }
            ChangePlayer();
        }
        
        public void BattleEnd(InFight player1, InFight player2)
        {
            foreach (var pokemon in player1.CurrentPokemonList)
                pokemon.Settlement(Experience(player2));
        }


        public int Experience(InFight you)
        {
            int totalExperience = 0;
            foreach (var pokemon in you.CurrentPokemonList)
            {
                totalExperience += pokemon.Lv1 * pokemon.BasicExperience1;
            }
            return (int)(1.5 * 1.5 * totalExperience / 7 / 3);
        }


        

        //private BackGround _backGround;

        //private PokemonAnimation _pokemonAnimation;

        //private BattlePage _pages;//需要切换的页面

        //private IBattlePage _battlePage;


        // public Pokemon GETMyPokemon()
        // {
        //     return _myPokemon;
        // }
        //
        // public void CreatePage()
        // {
        //     _battlePage.Create(this);
        // }
        //
        // public void SetIBattlePage(IBattlePage iBattlePage)
        // {
        //     this._battlePage = iBattlePage;
        //     
        // }
    }
}