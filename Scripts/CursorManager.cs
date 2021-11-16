using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{

	public static CursorManager _instance;//单例模式

	public Texture2D cursor_normal;
	public Texture2D cursor_npc_talk;
	//若需要更多的形状，则多创建几个 Texture2D类型的
	//拖入素材

	private Vector2 hotSpot = Vector2.zero;
	private CursorMode mode = CursorMode.Auto;//设置光标使用软件呈现还是在支持的平台上使用硬件呈现


	// Use this for initialization
	void Start()
	{
		_instance = this;
	}
	public void SetNormal()//设置普通的鼠标形状
	{
		Cursor.SetCursor(cursor_normal, hotSpot, mode);
	}

	public void SetNpcTalk()//设置触碰到物体的鼠标形状
	{
		Cursor.SetCursor(cursor_npc_talk, hotSpot, mode);
	}

	//这里可以多创建几个触碰到物体的方法
	//格式为
	//public void SetNpcTalk()方法名可以随便设置
	//{
	//	Cursor.SetCursor(这里为触碰到物体后的形状, hotSpot, mode);
	//}

	// Update is called once per frame
	void Update()
	{

	}
}
