//Depth

using UnityEngine;
using System.Collections;

public class Depth : MonoBehaviour {
	private float Yposition;
	private float Xposition;
	
	// Update is called once per frame
	void Update () 
	{
		Xposition = transform.position.x;
		Yposition = transform.position.y;
		transform.position = new Vector3(Xposition, Yposition, Yposition);
	}
}
