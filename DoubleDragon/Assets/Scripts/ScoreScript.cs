using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	public static int scoreValue = 0;

	GUIText score;
	// Use this for initialization
	void Start () {
	
		score = GetComponent<GUIText> ();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score: " + scoreValue;
	}
}
