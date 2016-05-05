using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelectModel : MonoBehaviour {
	public GameObject[] list;
	public GameObject buttons;
	public Text title;
	string[] name_list = {"남성 상체 해부도","남성 다리 해부도", "남성 하체 해부도",
	"남성 골격 해부도", "여성 하체 해부도", "여성 전신 해부도"};
	public void select(int num)
	{
		foreach(var i in list)
		{
			i.SetActive(false);
		}
		list[num].SetActive(true);
		title.text = name_list[num];
	}
}
