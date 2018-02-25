using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public float delay = 1f;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, delay);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
