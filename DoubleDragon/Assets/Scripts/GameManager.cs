using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public Transform platformGenerator;
	private Vector3 platformStartpoint;

	public Controls player;
	private Vector3 playerStartpoint;

	// Use this for initialization
	void Start () {

	platformStartpoint = platformGenerator.position;
	playerStartpoint = player.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void restartgame()
	{
		StartCoroutine("RestartGame");
	}

	public IEnumerator Restartgame()
		{
				player.gameObject.SetActive(false);
				yield return new WaitForSeconds (0.5f);
				player.transform.position = playerStartpoint;
				platformGenerator.position = platformStartpoint;
				player.gameObject.SetActive (true);
		}
}
