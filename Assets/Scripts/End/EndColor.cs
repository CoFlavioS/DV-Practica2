using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndColor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("aaaaa");
        other.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
