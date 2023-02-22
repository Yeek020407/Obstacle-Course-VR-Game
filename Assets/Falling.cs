using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public GameObject spike;
    public GameObject spike2;
    public GameObject spike3;
    public GameObject spike4;
    public GameObject spike5;
    public GameObject spike6;
    public GameObject spike7;

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {   
            Debug.LogError("Yes");
            spike.GetComponent<Rigidbody>().useGravity = true;
            spike2.GetComponent<Rigidbody>().useGravity = true;
            spike3.GetComponent<Rigidbody>().useGravity = true;
            spike4.GetComponent<Rigidbody>().useGravity = true;
            spike5.GetComponent<Rigidbody>().useGravity = true;
            spike6.GetComponent<Rigidbody>().useGravity = true;
            spike7.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}