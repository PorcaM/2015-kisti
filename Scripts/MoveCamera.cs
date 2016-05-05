using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	public Camera macamera;
	public Light malight;
	public Transform MainCamera;
	public Scrollbar scroll, scroll2, scroll3;
	float r = 10;
	float theta = 0;
	float y = 0;
	public void vert_scroll()
	{
		y = -(scroll3.value - 0.5f) * r;
		MainCamera.position = new Vector3(-Mathf.Sin(Mathf.Deg2Rad * theta) * r, y,
			-Mathf.Cos(Mathf.Deg2Rad * theta) * r);
	}
	public void dist_scroll()
	{
		r = scroll2.value * 10;
		MainCamera.position = new Vector3(-Mathf.Sin(Mathf.Deg2Rad * theta) * r, y,
			-Mathf.Cos(Mathf.Deg2Rad * theta) * r);
	}
	public void rot_scroll()
	{
		theta = scroll.value * 360;
		Quaternion temp = new Quaternion();
		temp.eulerAngles = new Vector3(0, theta, 0);
		MainCamera.rotation = temp;


		MainCamera.position = new Vector3(-Mathf.Sin(Mathf.Deg2Rad * theta) * r, y,
			-Mathf.Cos(Mathf.Deg2Rad * theta) * r);
	}
	public void moveCamera(string input)
	{
		Debug.Log(input);
		if (input == "pos1")                // 앞
		{
			MainCamera.position = new Vector3(0, 0, -10);
			MainCamera.eulerAngles = new Vector3(0, 0, 0);
		}
		else if (input == "pos2")       // 뒤
		{
			MainCamera.position = new Vector3(0, 0, 10);
			MainCamera.eulerAngles = new Vector3(0, -180, 0);
		}
		else if (input == "pos3")       // 좌
		{
			MainCamera.position = new Vector3(-10, 0, 0);
			MainCamera.eulerAngles = new Vector3(0, 90, 0);
		}
		else if (input == "pos4")       // 우
		{
			MainCamera.position = new Vector3(10, 0, 0);
			MainCamera.eulerAngles = new Vector3(0, -90, 0);
		}
		else if (input == "bgcolor")
		{
			macamera.GetComponent<Camera>().clearFlags = CameraClearFlags.SolidColor;
			if(macamera.GetComponent<Camera>().backgroundColor == Color.white)
			{
				macamera.GetComponent<Camera>().backgroundColor = Color.black;
            }
			else if (macamera.GetComponent<Camera>().backgroundColor == Color.black)
			{
				macamera.GetComponent<Camera>().backgroundColor = Color.gray;
            }
            else
			{
				macamera.GetComponent<Camera>().backgroundColor = Color.white;
			}
        }
		else if(input=="bglight")
		{
			if(malight.intensity>0.9f)
			{
				malight.intensity = 0.1f;
			}
			else
			{
				malight.intensity = 1f;
			}
			
		}
		//else if (input == "rot_clock" || input == "rot_unclock")
		//{
		//	theta = MainCamera.eulerAngles.y;
		//	if (input == "rot_clock") theta++;
		//	else theta--;
		//	Quaternion temp = new Quaternion();
		//	temp.eulerAngles=new Vector3(0, theta, 0);
		//	MainCamera.rotation = temp;

		//	MainCamera.position=new Vector3(-Mathf.Sin(Mathf.Deg2Rad*theta) * r, 0,
		//		-Mathf.Cos(Mathf.Deg2Rad * theta) * r);
		//}
		
	}
}
