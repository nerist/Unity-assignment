using UnityEngine;
using System.Collections;

public class powerup2 : MonoBehaviour {
	public GameObject ballSecond;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

void OnCollisionEnter2D (Collision2D otherObjectt)
{
	if (otherObjectt.gameObject.tag == "paddle") {
		Instantiate (ballSecond, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler (new Vector3 (0, 0, 90)));
		Destroy (this.gameObject);
		
		
	}
}
} 
