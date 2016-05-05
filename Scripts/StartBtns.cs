using UnityEngine;
using System.Collections;

public class StartBtns : MonoBehaviour {
	public GameObject wind_info;
	public void open_url()
	{
		Debug.Log("hi");
		Application.OpenURL("http://vkh3.kisti.re.kr/?q=node/1");
	}
	public void open_wind_info()
	{
		wind_info.SetActive(true);
	}
	public void close_wind_info()
	{
		wind_info.SetActive(false);
	}
	public void open_scene_main()
	{
		Application.LoadLevel("Main");
	}
	public void open_scene_vufo()
	{
		Application.LoadLevel("Vufo");
	}
}
