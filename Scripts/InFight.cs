using System;
using System.Collections;
using System.Collections.Generic;
using Stuff.Medicine;
using Pokemon.Species;
using Stuff;
using UnityEditor;
using UnityEngine;



public class InFight
{
    private string _name;//战斗前传入

    private Item[] _itemPack = new Item[5]; //hpSmall,hpLarge,ppSmall,ppLarge,status战斗前传入

    private int[] _itemNum = new int[5];//战斗前传入

    private Pokemon.Pokemon[] _pokemonPack = new Pokemon.Pokemon[6];//战斗前传入

    private Pokemon.Pokemon[] _currentPokemonList = new Pokemon.Pokemon[3];

    private Pokemon.Pokemon _currentPokemon;

    private int _death = 0;

    public InFight(string name)
    {
        _name = name;
        _itemPack[0] = new BloodSmall();
        _itemPack[1] = new BloodBig();
        _itemPack[2] = new PpSmall();
        _itemPack[3] = new PpBig();
        _itemPack[4] = new Status();

    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Item[] ItemPack
    {
        get => _itemPack;
        set => _itemPack = value;
    }

    public int Death
    {
        get => _death;
        set => _death = value;
    }

    public int[] ItemNum
    {
        get => _itemNum;
        set => _itemNum = value;
    }

    public Pokemon.Pokemon[] PokemonPack
    {
        get => _pokemonPack;
        set => _pokemonPack = value;
    }

    public Pokemon.Pokemon[] CurrentPokemonList
    {
        get => _currentPokemonList;
        set => _currentPokemonList = value;
    }

    public Pokemon.Pokemon CurrentPokemon
    {
        get => _currentPokemon;
        set => _currentPokemon = value;
    }
    
    
    
}