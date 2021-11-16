using System;
using System.Collections;
using System.Collections.Generic;
using Pokemon.Species;

using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        private string _name;

        private int _money;

        public BackpackStuff BackpackStuff
        {
            get => _backpackStuff;
            set => _backpackStuff = value;
        }

        public BackPackPokemon BackPackPokemon
        {
            get => _backPackPokemon;
            set => _backPackPokemon = value;
        }

        private BackpackStuff _backpackStuff;

        private BackPackPokemon _backPackPokemon;

        private Pokemon.Pokemon[] _currentPokemonList = new Pokemon.Pokemon[3]; 
        
        public float speed_move;

        public int Money
        {
            get => _money;
            set => _money = value;
        }

        private void Awake()
        {
            //_backpackStuff = this.AddComponent<BackpackStuff>();
            _name = "1";
            _money = 0;
            Application.targetFrameRate = 60;
        }

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(this._name);
            Debug.Log(this._money);
        }

        // Update is called once per frame
        void Update()
        {
        }
        void FixedUpdate()
        {
            Physics.gravity = new Vector3(0, -35, 0);
            float y = Input.GetAxis("Horizontal")
                      * Time.deltaTime * speed_move;
            float x = Input.GetAxis("Vertical")
                      * Time.deltaTime * speed_move;
            transform.Translate(-x, 0, y);


            if (Input.GetKey(KeyCode.Q))

            {

                transform.Rotate(new Vector3(0,1,0), -1.2f);

            }

            if (Input.GetKey(KeyCode.E))

            {

                transform.Rotate(new Vector3(0,1,0), 1.2f);

            }
        }
    }
}