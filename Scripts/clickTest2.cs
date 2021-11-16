using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickTest2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool WindowShow = false;
    void OnGUI()
    {
        if (WindowShow)
            GUI.Window(0, new Rect(30, 30, 200, 100), MyWindow, "窗口");
    }
    //对话框函数;
    void MyWindow(int WindowID)
    {
        GUILayout.Label("你需要写入的内容");
    }
    //鼠标点击事件;
    void OnMouseDown()
    {
        Debug.Log("show");
        if (WindowShow)
            WindowShow = false;
        else
            WindowShow = true;
    }
}
