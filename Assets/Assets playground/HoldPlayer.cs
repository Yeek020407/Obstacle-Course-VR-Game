using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HoldPlayer : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        col.transform.parent = gameObject.transform;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider col)
    {
        col.transform.parent = null;
    }
}
