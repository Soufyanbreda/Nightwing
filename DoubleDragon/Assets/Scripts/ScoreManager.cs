using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public GUIText scoreText;
	public GUIText highscoreText;

	public float scorecounter;
	public float hiscorecounter;

	public float pointsPerSecond;
	public bool scoreIncreasing;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		scoreText.text = "Score: " + scorecounter;
		highscoreText.text = "Highscore: " + hiscorecounter;

	}
}
