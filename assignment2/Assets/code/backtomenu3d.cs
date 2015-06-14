using UnityEngine;
using System.Collections;

public class backtomenu3d : MonoBehaviour {
	RaycastHit hit = new RaycastHit();
	Ray ray = new Ray();        
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0))  //Returns true during the frame the user touches the object
		{
			Debug.Log("mouse down");
			if (Physics.Raycast (ray, out hit)) 
			{
				Debug.Log("pew pew");
				if (hit.collider.gameObject.name.Equals("menu"))   
				{
					Application.LoadLevel(0);
				}
			}
		}
		else {
		}
}
}


