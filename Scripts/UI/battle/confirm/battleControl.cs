using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Player;
using UnityEngine.UI;

public class battleControl : MonoBehaviour
{
    private bool isPVP;
    private bool isbattling;
    public Player.Player player;
    public Player.Player player2;

    private int chooseCount;
    private bool flag;

    private Battle.Battle battle;
    private InFight infight;
    private InFight InFight2;

    public Image choose;
    public Image log;
    public Text log_Info;
    public Button[] buttons;// 放六个confrim用来确定是哪个按钮
    public Button[] buttonlist;//六个宝可梦的button
    // Start is called before the first frame update
    void Start()
    {
        BackPackPokemon backPackPokemon = new BackPackPokemon();
        Pokemon.Pokemon[] test1 = new Pokemon.Pokemon[6];
        test1[0] = new Pokemon.Species.Pikachu();
        test1[1] = new Pokemon.Species.Pidgey();
        test1[2] = new Pokemon.Species.Wartortle();
        test1[0].InitialPokemon(13);
        test1[1].InitialPokemon(23);
        test1[2].InitialPokemon(89);
        backPackPokemon.Pokemon = test1;
        player.BackPackPokemon = backPackPokemon;
        player2.BackPackPokemon = backPackPokemon;

        infight = new InFight(player.name);
        InFight2 = new InFight(player2.name);
        flag = false;

        Pokemon.Pokemon[] list = player.BackPackPokemon.Pokemon;
        for (int i = 0; i < 6; i++)
        {
            Pokemon.Pokemon pokemon = (Pokemon.Pokemon)list[i];
            if (pokemon == null)
            {
                Text[] text = buttonlist[i].gameObject.GetComponentsInChildren<Text>();
                text[0].text = "No pokemon";
                buttonlist[i].enabled = false;
            }
            else {
                Text[] text = buttonlist[i].gameObject.GetComponentsInChildren<Text>();
                text[0].text = pokemon.SpeciesName1;
            }
        }
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(delegate () {
                onClick(button, infight);
            });
        }

    }

    void onClick(Button button, InFight infight1)
    {
        if (isPVP == false || (isPVP == true && chooseCount<3))
        {
            switch (button.name)
            {
                case "yes":
                    infight1.CurrentPokemonList[chooseCount] = (Pokemon.Pokemon)player.BackPackPokemon.Pokemon[0];
                    buttonlist[0].enabled = false;
                    chooseCount++;
                    break;
                case "yes（1）":
                    infight1.CurrentPokemonList[chooseCount] = (Pokemon.Pokemon)player.BackPackPokemon.Pokemon[1];
                    buttonlist[1].enabled = false;
                    chooseCount++;
                    break;
                case "yes（2）":
                    infight1.CurrentPokemonList[chooseCount] = (Pokemon.Pokemon)player.BackPackPokemon.Pokemon[2];
                    buttonlist[2].enabled = false;
                    chooseCount++;
                    break;
                case "yes（3）":
                    infight1.CurrentPokemonList[chooseCount] = (Pokemon.Pokemon)player.BackPackPokemon.Pokemon[3];
                    buttonlist[3].enabled = false;
                    chooseCount++;
                    break;
                case "yes（4）":
                    infight1.CurrentPokemonList[chooseCount] = (Pokemon.Pokemon)player.BackPackPokemon.Pokemon[4];
                    buttonlist[4].enabled = false;
                    chooseCount++;
                    break;
                case "yes（5）":
                    infight1.CurrentPokemonList[chooseCount] = (Pokemon.Pokemon)player.BackPackPokemon.Pokemon[5];
                    buttonlist[5].enabled = false;
                    chooseCount++;
                    break;
                default:
                    Debug.LogWarning("No find button yes!!");
                    break;

            }
        }
        else if((isPVP == true && chooseCount >= 3))
        {
            switch (button.name)
            {
                case "yes":
                    infight1.CurrentPokemonList[chooseCount - 3] = (Pokemon.Pokemon)player2.BackPackPokemon.Pokemon[0];
                    buttonlist[0].enabled = false;
                    chooseCount++;
                    break;
                case "yes（1）":
                    infight1.CurrentPokemonList[chooseCount - 3] = (Pokemon.Pokemon)player2.BackPackPokemon.Pokemon[1];
                    buttonlist[1].enabled = false;
                    chooseCount++;
                    break;
                case "yes（2）":
                    infight1.CurrentPokemonList[chooseCount - 3] = (Pokemon.Pokemon)player2.BackPackPokemon.Pokemon[2];
                    buttonlist[2].enabled = false;
                    chooseCount++;
                    break;
                case "yes（3）":
                    infight1.CurrentPokemonList[chooseCount - 3] = (Pokemon.Pokemon)player2.BackPackPokemon.Pokemon[3];
                    buttonlist[3].enabled = false;
                    chooseCount++;
                    break;
                case "yes（4）":
                    infight1.CurrentPokemonList[chooseCount - 3] = (Pokemon.Pokemon)player2.BackPackPokemon.Pokemon[4];
                    buttonlist[4].enabled = false;
                    chooseCount++;
                    break;
                case "yes（5）":
                    infight1.CurrentPokemonList[chooseCount - 3] = (Pokemon.Pokemon)player2.BackPackPokemon.Pokemon[5];
                    buttonlist[5].enabled = false;
                    chooseCount++;
                    break;
                default:
                    Debug.LogWarning("No find button yes!!");
                    break;

            }

        }
    }

    public void isPvP(bool isPVP)
    {
        this.isPVP = isPVP;
    }

    public void setInfo(string str)
    {
        log.gameObject.SetActive(true);
        log_Info.text = str;
    }

    bool IsLogActive()
    {
        return log.IsActive();
    }


    // Update is called once per frame

    void Update()
    {
        if (isPVP && chooseCount == 3 && flag == false)
        {
            flag = true;
            Pokemon.Pokemon[] list = player2.BackPackPokemon.Pokemon;
            for (int i = 0; i < 6; i++)
            {
                Pokemon.Pokemon pokemon = (Pokemon.Pokemon)list[i];
                if (pokemon!=null)
                {
                    Text[] text = buttonlist[i].gameObject.GetComponentsInChildren<Text>();
                    text[0].text = pokemon.SpeciesName1;
                    buttonlist[i].enabled = true;
                }
                else
                {
                    Text[] text = buttonlist[i].gameObject.GetComponentsInChildren<Text>();
                    text[0].text = "No pokemon";
                    buttonlist[i].enabled = false;
                }
            }
            foreach (Button button in buttons)
            {
                button.onClick.RemoveAllListeners();
                button.onClick.AddListener(delegate ()
                {
                    onClick(button, InFight2);
                });
            }
        }
        if (!isPVP && chooseCount >= 3 && isbattling == false || isPVP && chooseCount>=6 && isbattling == false)
        {
            isbattling = true;
            setInfo("战斗开始！");
            choose.gameObject.SetActive(false);
            if (isPVP)
            {
               battle = new Battle.PvP(infight,InFight2);
            }
            else
            {
                battle = new Battle.PvE(infight);
            }
            whereplaycontrol.theBattle = battle;
            print(battle.Me1);
            whereplaycontrol.poke1 = battle.Me1.CurrentPokemonList;
            whereplaycontrol.poke2 = battle.You1.CurrentPokemonList;
            SceneManager.LoadScene("whereplay");
            // 开始战斗:切换新场景
        }
        if(IsLogActive() && Input.GetMouseButtonDown(0))
        {
            log.gameObject.SetActive(false);
        }
    }
}
