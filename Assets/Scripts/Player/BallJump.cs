using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    public int jumpForce = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse );
        }
    }
}
