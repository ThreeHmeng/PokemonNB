using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t1 : MonoBehaviour
{
    public bool WindowShow = false;
 

    void OnGUI()
    {
        GUIStyle labelFont = new GUIStyle();
        labelFont.fontSize = 20;
        if (WindowShow)
            GUI.Window(0, new Rect(80, 80, 250, 140), MyWindow, "������ʾ");
    }
    //�Ի�����;
    void MyWindow(int WindowID)
    {
        GUILayout.Label("��ӭ����Sustech-pokemon��" + "\n" +
            "�밴wasdqe�������ƶ�����������Ϥ��һ�̡�"+"\n"+
            "�뾡��̽�������");
    
    }
    //������¼�;
    void OnMouseDown()
    {
        Debug.Log("show");
        if (WindowShow)
            WindowShow = false;
        else
            WindowShow = true;
    }
}
