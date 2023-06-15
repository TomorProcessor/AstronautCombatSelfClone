using UnityEngine;
using System.Collections;

public class FireRocket : MonoBehaviour {

    public Rigidbody2D rocket = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown ("Fire1"))
        {
            for (int i = 0; i < 100; i++)
            {
                fire();
            }
        } 
	}

    private void fire()
    {
        Rigidbody2D rocketClone = (Rigidbody2D)Instantiate(rocket, GetComponent<Transform>().position, rocket.transform.rotation);
    }
}
