using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;
using UnityEngine.UI;

public class whereplaycontrol : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;


    public static Battle.Battle theBattle;

    public static Pokemon.Pokemon[] poke1;
    public static Pokemon.Pokemon[] poke2;

    private Pokemon.Pokemon us;
    private Pokemon.Pokemon enemy;

    public Text name1;
    public Text name2;

    public Text Lv1;
    public Text Lv2;

    public Text hp1;
    public Text hp2;

    public Image nuddle1;
    public Image nuddle2;

    public Text aMove1;
    public Text aMove2;
    public Text aMove3;
    public Text aMove4;



    private int prehp1;
    private int prehp2;
    void Start()
    {
        prehp1 = poke1[0].HpDefault1;
        prehp2 = poke2[0].HpDefault1;

        us = poke1[0];
        enemy = poke2[0];

        player1 = GameObject.Find(poke1[0].SpeciesName1+"1");
        player2 = GameObject.Find(poke2[0].SpeciesName1 + "2");

        name2.text = poke2[0].SpeciesName1;
        name1.text = poke1[0].SpeciesName1;

        Lv1.text = "Lv "+poke1[0].Lv1.ToString();
        Lv2.text = "Lv "+poke2[0].Lv1.ToString();

        hp1.text = "Hp: " + poke1[0].HpCurrent1 + "/" + poke1[0].HpDefault1;
        hp2.text = "Hp: " + poke2[0].HpCurrent1 + "/" + poke2[0].HpDefault1;

        setMoves();

        post();
    }

    public void setMoves()
    {

        if (poke1[0].CurrentMoves1[0] != null)
        {
            aMove1.text = us.CurrentMoves1[0].MoveName1;
        }
        if (poke1[0].CurrentMoves1[1] != null)
        {
            aMove2.text = us.CurrentMoves1[1].MoveName1;
        }
        if (poke1[0].CurrentMoves1[2] != null)
        {
            aMove3.text = us.CurrentMoves1[2].MoveName1;
        }
        if (poke1[0].CurrentMoves1[3] != null)
        {
            aMove4.text = us.CurrentMoves1[3].MoveName1;
        }
    }

    
    void Update()
    {
        hp1.text = "Hp: " + us.HpCurrent1 + "/" + us.HpDefault1;
        hp2.text = "Hp: " + enemy.HpCurrent1 + "/" + enemy.HpDefault1;

        setMoves();

        if (prehp1 != us.HpCurrent1)
        {
            nuddle1.fillAmount -= (float)((float)(prehp1 - us.HpCurrent1) / us.HpDefault1);
            prehp1 = us.HpCurrent1;
        }

        if (prehp2 != enemy.HpCurrent1)
        {
            nuddle2.fillAmount -= (float)((float)(prehp2 - enemy.HpCurrent1) / enemy.HpDefault1);
            prehp2 = enemy.HpCurrent1;
        }

        
        if (poke1[0].HpCurrent1 <= 0 && poke1[1].HpCurrent1 == poke1[1].HpDefault1)
        {
            us = poke1[1];
            player1.transform.position = new Vector3(0, 0, 0);
            player1 = GameObject.Find(poke1[1].SpeciesName1 + "1");
            nuddle1.fillAmount = 1;
            name1.text = poke1[1].SpeciesName1;
            hp1.text = "Hp: " + poke1[1].HpCurrent1 + "/" + poke1[1].HpDefault1;
            Lv1.text = "Lv " + poke1[1].Lv1.ToString();
            post1();
        }
        else if (poke1[1].HpCurrent1 <= 0 && poke1[2].HpCurrent1 == poke1[2].HpDefault1)
        {
            us = poke1[2];
            player1.transform.position = new Vector3(0, 0, 0);
            player1 = GameObject.Find(poke1[2].SpeciesName1 + "1");
            nuddle1.fillAmount = 1;
            name1.text = poke1[2].SpeciesName1;
            hp1.text = "Hp: " + poke1[2].HpCurrent1 + "/" + poke1[2].HpDefault1;
            Lv1.text = "Lv " + poke1[2].Lv1.ToString();
            post1();
        }
        if (poke2[0].HpCurrent1 <= 0 && poke2[1].HpCurrent1 == poke2[1].HpDefault1)
        {
            enemy = poke2[1];
            player2.transform.position = new Vector3(0, 0, 0);
            player2 = GameObject.Find(poke2[1].SpeciesName1 + "2");
            nuddle2.fillAmount = 1;
            name2.text = poke2[1].SpeciesName1;
            hp2.text = "Hp: " + poke2[1].HpCurrent1 + "/" + poke2[1].HpDefault1;
            Lv2.text = "Lv " + poke2[1].Lv1.ToString();
            post2();
        }
        else if (poke2[1].HpCurrent1 <= 0 && poke2[2].HpCurrent1 == poke2[2].HpDefault1)
        {
            enemy = poke2[2];
            player2.transform.position = new Vector3(0, 0, 0);
            player2 = GameObject.Find(poke2[2].SpeciesName1 + "2");
            nuddle2.fillAmount = 1;
            name2.text = poke2[2].SpeciesName1;
            hp2.text = "Hp: " + poke2[2].HpCurrent1 + "/" + poke2[2].HpDefault1;
            Lv2.text = "Lv " + poke2[2].Lv1.ToString();
            post2();
        }
    }

    void post()
    {
        player1.transform.position = new Vector3(-598, 18, 579);
        player2.transform.position = new Vector3(-717, 18, 573);
    }
    void post1()
    {
        player1.transform.position = new Vector3(-598, 18, 579);
    }
    void post2()
    {
        player2.transform.position = new Vector3(-717, 18, 573);
    }

}
