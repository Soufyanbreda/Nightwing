using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	private Rigidbody2D rb;
	public float movespeed;
	public float jumpspeed;

	// Use this for initialization
	void Start () {
	rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			rb.velocity = new Vector2(-movespeed, rb.velocity.y);
		}
	if (Input.GetKey (KeyCode.RightArrow))
		{
			rb.velocity = new Vector2(movespeed, rb.velocity.y);
		}
		if (Input.GetMouseButtonDown (0))
		{
			rb.AddForce(new Vector2(0, jumpspeed),ForceMode2D.Impulse);
		}
	}
}
