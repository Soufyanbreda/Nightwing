using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	private Rigidbody2D rb;
	public float movespeed = 3;
	public float jumpspeed = 5;
	public float increase;
	public float maxIncrease = 100;
	public Transform renderer;

	public bool grounded;
	
	public LayerMask whatIsGround;

	private Collider2D myCollider;
	
	private Animator myAnimator; 

	public GameManager thegameManager;

	// Use this for initialization
	void Start () {
	rb = GetComponent<Rigidbody2D>();
	myCollider = GetComponent<Collider2D> ();
	myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		grounded = Physics2D.IsTouchingLayers (myCollider, whatIsGround);

		rb.velocity = new Vector2(movespeed, rb.velocity.y);
	
		if (++increase == maxIncrease) 
		{
			movespeed++;
			increase = 0;
		}

		if (Input.GetMouseButtonDown (0))
		{
			if(grounded)
			{
				rb.AddForce(new Vector2(0, 5),ForceMode2D.Impulse);
			}			
			
		}
				myAnimator.SetFloat ("Speed", rb.velocity.x);
				myAnimator.SetBool ("Grounded", grounded);

	}

	private void LookDirection(int direction)
	{
		renderer.localScale = new Vector3 (Mathf.Abs (renderer.localScale.x) * direction,
		                        renderer.localScale.y,
		                        renderer.localScale.z);
		}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "killbox")
			{
				Application.LoadLevel(Application.loadedLevel);	
			}		
	}

}
