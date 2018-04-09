using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D myRigidBody;
    public float playerFloatForce = 300f;

	// Use this for initialization
	void Start ()
    {
        myRigidBody = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetButtonDown("Vertical"))
        {
            myRigidBody.AddForce(transform.up * playerFloatForce);
        }
	}
}
