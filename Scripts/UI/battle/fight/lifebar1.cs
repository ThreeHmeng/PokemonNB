
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifebar1 : MonoBehaviour
{
    Image img;
    // Use this for initialization
    void Start()
    {
        img = GetComponent<Image>();    //��ȡImage���
    }

    // Update is called once per frame
    void Update()
    {
        //Ѫ������
        if (Input.GetKey(KeyCode.A))
        {
            img.fillAmount -= 0.01f;
        }
        //Ѫ������
        if (Input.GetKey(KeyCode.D))
        {
            img.fillAmount += 0.01f;
        }
    }
}
