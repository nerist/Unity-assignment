using UnityEngine;
using System.Collections;

public class empoweredorb : MonoBehaviour {
	Collider2D other;
	public GameObject power1;
	public GameObject power2;
	public GameObject power3;
	int dice;
	float angle;
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
			Destroy (this.gameObject);
		
	}
}
	IEnumerator destroyEnemy()
	{
		yield return new WaitForSeconds (0.000f);
		if (other.gameObject != null) {
			dice = Random.Range (1,30);
			GM.score++;
			Debug.Log (dice);
		}
		if (dice == 1f) {
			Instantiate (power1, transform.position, transform.rotation);
			rigidbody2D.velocity = 6f * transform.up;
			
		}
		if (dice == 2f) {
			Instantiate (power2, transform.position, transform.rotation);
			rigidbody2D.velocity = 6f * transform.up;
		}
		if (dice == 3f) {
			Instantiate (power3, transform.position, transform.rotation);
			rigidbody2D.velocity = 6f * transform.up;
		}
	}
	
	
	void OnCollisionEnter2D (Collision2D otherObject)
	{
		if (otherObject.gameObject.tag == "break") {
			audio.PlayOneShot(hit);
			other = otherObject.collider;
			StartCoroutine ("destroyEnemy");
			Destroy (other.gameObject);
			}
		if (otherObject.gameObject.tag == "ball") {
			rigidbody2D.velocity = 6f * transform.up;
		}
		if (otherObject.gameObject.tag == "power1tag") {
			rigidbody2D.velocity = 6f * transform.up;
		}
		if (otherObject.gameObject.tag == "power2tag") {
			rigidbody2D.velocity = 6f * transform.up;
		}
		if (otherObject.gameObject.tag == "power3tag") {
			rigidbody2D.velocity = 6f * transform.up;
		}
		if (otherObject.gameObject.tag == "paddle") {
			audio.PlayOneShot(hitpaddle);
		}
		}
}
