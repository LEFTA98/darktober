using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody2D rigidbody;

    public float horizSpeed = 1;
    public float vertSpeed = 1;

    // Use this for initialization
    void Start () {

        rigidbody = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

        //Horizontal movement
        float horizontal = 0f;
        horizontal = Input.GetAxisRaw("Horizontal");

        //Vertical movement
        float vertical = 0f;
        if (Input.GetButtonDown("Jump"))
        {
            vertical = 5f;
        }
        else {

            vertical = 0f;

        }

        rigidbody.velocity = new Vector2(horizontal * horizSpeed, vertical * vertSpeed + rigidbody.velocity.y);
		
	}
}
