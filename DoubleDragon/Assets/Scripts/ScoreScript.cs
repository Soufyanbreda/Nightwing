using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text scoreText;

	public Text hiscoreText;

	public float scoreValue;

	public float hiscoreValue;

	public float pointsPerSecond;


	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
		scoreValue += pointsPerSecond * Time.deltaTime;

		if (scoreValue > hiscoreValue)
		{
		  hiscoreValue = scoreValue;
		}
	
		scoreText.text = "Score: " + Mathf.Round(scoreValue);
		
		hiscoreText.text = "High Score: " + Mathf.Round(hiscoreValue);
	}
}
