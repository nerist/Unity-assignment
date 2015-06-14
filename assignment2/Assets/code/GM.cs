using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {
	public static int score;
	public static int lives;
	public GUISkin stylesheet;
	// Use this for initialization
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
	void OnGUI ()
	{
		//to load stylesheet
		GUI.skin = stylesheet;
		string ScoreLabel = "Score:";
		string LivesLabel = "Lives:";
		//(posx,posy,width,height)
		GUI.Label (new Rect (10f, 10f, 150, 20), ScoreLabel + score);
		//created space by adding 15px of spaceing
		GUI.Label (new Rect (Screen.width - 80f, 10f, 150, 20), LivesLabel + lives);
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
