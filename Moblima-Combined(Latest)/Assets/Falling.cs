using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public GameObject spike;
    public GameObject spike2;
    public GameObject spike3;
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "trig")
        {   
            Debug.LogError("Yes");
            spike.GetComponent<Rigidbody>().useGravity = true;
            spike2.GetComponent<Rigidbody>().useGravity = true;
            spike3.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}