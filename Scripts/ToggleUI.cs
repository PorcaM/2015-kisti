using UnityEngine;
using System.Collections;

public class ToggleUI : MonoBehaviour {
	public GameObject IngameUI, MenuPanel;
	public GameObject Menu;
	public void toggle_ig()
	{
		IngameUI.SetActive(!IngameUI.active);
	}
	void Start()
	{
		MenuPanel.SetActive(false);
	}
	public void toggle_mp()
	{
		toggle_ig();
		MenuPanel.SetActive(!MenuPanel.active);
		Vector3 pos = Menu.transform.localPosition;
        if (MenuPanel.active)
		{
			pos.x = -155;
		}
		else
		{
			pos.x = 109f;
		}
		Menu.transform.localPosition = pos;
	}
}
