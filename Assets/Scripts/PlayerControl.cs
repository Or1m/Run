using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    [SerializeField]
    private Rigidbody playerRigid;

    [SerializeField]
    private float forwardForce = 2000f;

    [SerializeField]
    private float sideForce = 50f;

    private bool left = false;
    private bool right = false;
    private bool forward = false;
    private bool back = false;

	// Update is called once per frame
	void Update () {

		if(Input.GetKey("a")) {
            left = true;
        }

        if (Input.GetKey("w")) {
            forward = true;
        }

        if (Input.GetKey("d")) {
            right = true;
        }

        if (Input.GetKey("s")) {
            back = true;
        }


        if (Input.GetKeyUp("a")) {
            left = false;
        }

        if (Input.GetKeyUp("w")) {
            forward = false;
        }

        if (Input.GetKeyUp("d")) {
            right = false;
        }

        if (Input.GetKeyUp("s")) {
            back = false;
        }
    }

    void FixedUpdate() {

        if (right)
            playerRigid.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (left)
            playerRigid.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (forward)
            playerRigid.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (back)
            playerRigid.AddForce(0, 0, -forwardForce * Time.deltaTime);

    }
}
