using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	public GameObject unpauseButton;
	public AudioClip pausa;
	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() {
		audio.PlayOneShot(pausa);
		Time.timeScale=0;

			
			GameObject varGameObject = GameObject.FindWithTag("paddle");
			
			varGameObject.GetComponent<paddlecontroller>().enabled = false;
		Instantiate (unpauseButton, new Vector3 (-0.06f, 0.05f, -2f), Quaternion.Euler (new Vector3 (0, 0, 0)));
		}
		}
	

