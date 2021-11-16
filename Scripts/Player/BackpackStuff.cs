using System;
using System.Collections;

using UnityEngine;

namespace Player
{
    using Pokemon;
    public class BackpackStuff :MonoBehaviour
    {
        private ArrayList _stuffList;//物品栏

        public ArrayList StuffList
        {
            get => _stuffList;
            set => _stuffList = value;
        }


        public void Awake()
        {
        }
        
        
    }
}