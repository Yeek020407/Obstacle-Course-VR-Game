using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        col.transform.parent = gameObject.transform;
        col.transform.localScale = new Vector3(0.33f, 1/0.27f, 1/3f);
        col.transform.localRotation =  Quaternion.Euler(0, -112, 0);
        
        
    }

    // Update is called once per frame
    void OnTriggerExit(Collider col)
    {
        col.transform.parent = null;
        col.transform.localScale = new Vector3(1,1,1);
        col.transform.localRotation =  Quaternion.Euler(0, -112, 0);
    }
}
