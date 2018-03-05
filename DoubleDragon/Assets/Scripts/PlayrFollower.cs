using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayrFollower : MonoBehaviour {
		public Transform Player;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
				this.transform.position = new Vector3 (Player.position.x, this.transform.position.y, this.transform.position.z);
	}
}
