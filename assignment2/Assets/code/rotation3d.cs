using UnityEngine;
using System.Collections;

public class rotation3d : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * 10f * Time.deltaTime);
	}
}
