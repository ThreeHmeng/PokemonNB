using System.Collections;
using Pokemon.ExpSpeed;
using Pokemon.Type;

namespace Battle
{
    public class PvE : Battle
    {
        public PvE(InFight me)
        {
            Me = me; 
            You = new InFight("OOAD");
            You.ItemNum[0] = 0;
            You.ItemNum[1] = 0;
            You.ItemNum[2] = 0;
            You.ItemNum[3] = 0;
            You.ItemNum[4] = 0;
            You.CurrentPokemonList[0] = new Pokemon.Pokemon();
            You.CurrentPokemonList[0] = You.CurrentPokemonList[0].SetPokemonRandomly(Me.CurrentPokemonList[0].Lv1);
            You.CurrentPokemonList[1] = new Pokemon.Pokemon();
            You.CurrentPokemonList[1] = You.CurrentPokemonList[1].SetPokemonRandomly(Me.CurrentPokemonList[1].Lv1);
            You.CurrentPokemonList[2] = new Pokemon.Pokemon();
            You.CurrentPokemonList[2] = You.CurrentPokemonList[2].SetPokemonRandomly(Me.CurrentPokemonList[2].Lv1);//random
        }

        
        
    }
}