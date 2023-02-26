using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holdplayer2 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Player")
        {
            col.gameObject.transform.SetParent(transform);
        
        
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.name == "Player")
        {
            col.gameObject.transform.SetParent(null);
            col.transform.localScale = new Vector3(1,1,1);
            
        }
    }
}
