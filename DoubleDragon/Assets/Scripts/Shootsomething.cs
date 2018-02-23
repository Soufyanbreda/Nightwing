﻿using UnityEngine;
using System.Collections;

public class Shootsomething : MonoBehaviour {

	public GameObject projectile;
	public Vector2 velocity;
	public bool canShoot = true;
	public Vector2 offset;
	public float cooldown = 1f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (0) && canShoot)
		{
			GameObject go =	(GameObject) Instantiate (projectile, (Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);

			go.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x * transform.localScale.x,velocity.y);
		}
	}

	IEnumerator CanShoot()
	{
		canShoot = false;
		yield return new WaitForSeconds(cooldown);
		canShoot = true; 
	}

}
