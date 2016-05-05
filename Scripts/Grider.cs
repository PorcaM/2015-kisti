using UnityEngine;
using System.Collections;

public class Grider : MonoBehaviour {
	public float size;
	void Start()
	{
		int n = -1;
		foreach(var i in this.GetComponentsInChildren<Transform>())
		{
			if(n!=-1)
				i.localPosition = new Vector3(0, -size * n, 0);
			n++;
		}
	}
}
