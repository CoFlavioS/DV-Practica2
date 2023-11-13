using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowCatapult : MonoBehaviour
{
    public int catapultPower = 5;
    public int waitTime = 2;
    float timeElapsed;

    private void Start()
    {
        timeElapsed = 0;
    }

    private void OnCollisionStay(Collision collision)
    {
        timeElapsed += Time.deltaTime;
    }

    void Update()
    {
        if(timeElapsed >= waitTime - 0.1f && timeElapsed <= waitTime + 0.1f)
        this.GetComponent<Rigidbody>().AddForce(Vector3.up * catapultPower, ForceMode.Impulse);
    }
}
