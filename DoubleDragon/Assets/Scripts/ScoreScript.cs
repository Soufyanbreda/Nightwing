using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	public GUIText scoreText;

	public float scoreValue;

	public float pointsPerSecond;


	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
		scoreValue += pointsPerSecond * Time.deltaTime;

		scoreText.text = "Score: " + Mathf.Round(scoreValue);
	}
}
