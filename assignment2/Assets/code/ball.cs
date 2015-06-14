using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	Collider2D other;


	public GameObject power1;
	public GameObject power2;
	public GameObject power3;
	int dice;
	public AudioClip hit;
	public AudioClip hitpaddle;




	// Use this for initialization
	void Start () {

		transform.rotation = Quaternion.Euler (0f, 0f,140f);
		rigidbody2D.velocity = 6f * transform.up;
		transform.Rotate(Time.deltaTime, 15, 0);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y < -10) {
			transform.position = new Vector3 (0f, 0f, 0f);
			transform.rotation = Quaternion.Euler (0f, 0f,130f);
			GM.lives--;
		}



	}
	


void OnCollisionEnter2D (Collision2D otherObject)
{
	if (otherObject.gameObject.tag == "break") {

			other = otherObject.collider;

			Destroy (other.gameObject);
		}

	
	

}
}


	
	
	
	