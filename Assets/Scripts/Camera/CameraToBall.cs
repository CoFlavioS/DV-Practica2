using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToBall : MonoBehaviour
{
    public GameObject mainFocus;

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.LookRotation( mainFocus.transform.position - this.transform.position );
        this.GetComponent<Camera>().fieldOfView = 30 - (Vector3.Distance(mainFocus.transform.position, this.transform.position) / 7);
    }
}
