using UnityEngine;
using System.Collections;

public class powerup1 : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D (Collision2D otherObject)
	{
		if (otherObject.gameObject.tag == "paddle") {
			GM.lives++;
			Destroy (this.gameObject);

		}
} 
}