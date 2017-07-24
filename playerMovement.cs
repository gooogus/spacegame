using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {


    public GameObject ship;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {

        ship.GetComponent<Rigidbody>();

    }



    float Horthrust = 350f;
    float Verthrust = 200f;


	
	// Update is called once per frame
	void Update () {

        float speed = rb.velocity.magnitude;
        

        //checks for right on joy stick
        if (Input.GetAxis("Horizontal (Controller)") > 0 || Input.GetAxis("Horizontal (Key)") > 0)
        {
            rb.AddForce(transform.forward * -Horthrust);
        }

        // checks for left movement
		if (Input.GetAxis("Horizontal (Controller)") < 0 || Input.GetAxis("Horizontal (Key)" ) < 0)
        {
            rb.AddForce(transform.forward * Horthrust);
        }

        // checks for up
        if (Input.GetAxis("Vertical (Controller)") > 0 || Input.GetAxis("Vertical (Key)") > 0)
        {
            rb.AddForce(transform.right * Verthrust);

            // prevents excessive diagional speed
            if (Input.GetAxis("Horizontal (Controller)") > 0 || Input.GetAxis("Horizontal (Key)") > 0)
            {
                rb.AddForce(transform.forward * 250);
            }
            else if (Input.GetAxis("Horizontal (Controller)") < 0 || Input.GetAxis("Horizontal (Key)") < 0)
            {
                rb.AddForce(transform.forward * -250);
            }

        }

        // checks for down
        if (Input.GetAxis("Vertical (Controller)") < 0 || Input.GetAxis("Vertical (Key)") < 0)
        {
            rb.AddForce(transform.right * -Verthrust);

            if (Input.GetAxis("Horizontal (Controller)") > 0 || Input.GetAxis("Horizontal (Key)") > 0)
            {
                rb.AddForce(transform.forward * 250);
            }
            else if (Input.GetAxis("Horizontal (Controller)") < 0 || Input.GetAxis("Horizontal (Key)") < 0)
            {
                rb.AddForce(transform.forward * -250);
            }

        }

        Debug.Log("Speed is" + rb.velocity.magnitude);

	}
}
