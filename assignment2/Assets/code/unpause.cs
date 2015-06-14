using UnityEngine;
using System.Collections;

public class unpause : MonoBehaviour {
	public AudioClip pausa;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() {

		Time.timeScale=1;
		GameObject varGameObject = GameObject.FindWithTag("paddle");
		audio.PlayOneShot(pausa);
		
		varGameObject.GetComponent<paddlecontroller>().enabled = true;
		Destroy(this.gameObject);

	}
}
