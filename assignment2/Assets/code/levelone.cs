using UnityEngine;
using System.Collections;

public class levelone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GM.lives = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if ( GameObject.FindGameObjectsWithTag("break").Length == 0)
		{
			Application.LoadLevel ("1.5");
		}
		if (GM.lives == 0) {
			Application.LoadLevel("gameover");
		}
	}
}
