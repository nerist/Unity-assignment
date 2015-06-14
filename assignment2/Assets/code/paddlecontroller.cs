using UnityEngine;
using System.Collections;

public class paddlecontroller : MonoBehaviour {
	//1. the mouse position in screen coordinates
	Vector3 mousePos;
	//2. the mouse position in world coordinates
	Vector3 mPos;
	// Use this for initialization
	Collider2D other;
	public AudioClip powerclip;
	void Start () {
	
	}

	IEnumerator tallman()
	{

		if (other.gameObject != null) {
			Destroy (other.gameObject);
			transform.localScale += new Vector3 (0.3F, 0.2f, 0);
		}
		yield return new WaitForSeconds (10f);
		transform.localScale -= new Vector3 (0.3F, 0.2f, 0);

	}
	
	// Update is called once per frame
	void Update () {
		
		//3. this line of code gets the mouse position in pixels
		mousePos = Input.mousePosition;
		
		//4. this line of code translates from pixels to spaceship based coordinates
		mPos = Camera.main.ScreenToWorldPoint (mousePos);
		
		//5. this line of code sets the x and y position of the spaceship
		transform.position = new Vector3 (Mathf.Clamp (mPos.x,-5.73f,5.73f),-3.27f, 0f);
	
	
	}
	void OnCollisionEnter2D (Collision2D otherObject)
	{
		if (otherObject.gameObject.tag == "power3tag") {
			audio.PlayOneShot(powerclip);
			other = otherObject.collider;
			StartCoroutine ("tallman");
			
		}
		if (otherObject.gameObject.tag == "power2tag") {
			audio.PlayOneShot(powerclip);

			}
		if (otherObject.gameObject.tag == "power1tag") {
			audio.PlayOneShot(powerclip);
			
		}
	}
}
