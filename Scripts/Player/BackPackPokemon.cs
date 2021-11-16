using System;
using System.Collections;
using UnityEngine;

namespace Player
{
    using Pokemon;
    public class BackPackPokemon :MonoBehaviour
    {
        private Pokemon[] _pokemon = new Pokemon[6];//物品栏

        public Pokemon[] Pokemon
        {
            get => _pokemon;
            set => _pokemon = value;
        }
        public void Awake()
        {
            
        }
    }
}