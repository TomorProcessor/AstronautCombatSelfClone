using UnityEngine;
using System.Collections;

public class CharacterMovementScript : MonoBehaviour {

    public float speed = 2.0f;
    private Rigidbody2D rigidbody2d;
    private bool facingRight = true;
    public float jumpForce = 2.0f;

	// Use this for initialization
	void Start () {

        this.rigidbody2d = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {



        /*
            A unitiben alapból definiált horizontal axes. unitiben az input managernél érjük el.
            Az exes-ek külön is definiálhatóak. A float értékből fogjuk tudni, hogy merre megyünk.
        */
        float direction = Input.GetAxis("Horizontal");

        //így kérünk le és módosítunk komponenst

        this.rigidbody2d.velocity = new Vector2(direction*this.speed, rigidbody2d.velocity.y);


        if (direction > 0 && !facingRight)
        {
            flip();
        } else if (direction < 0 && facingRight)
        {
            flip();
        }

        if (Input.GetButtonDown("Jump"))
        { 
            
            this.rigidbody2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
	}


    private void flip()
    {
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
