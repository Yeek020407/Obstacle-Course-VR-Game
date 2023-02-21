using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welcome : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject welcome;
    void OnTriggerStay(Collider col){
        if(col.tag == "Player"){
            welcome.SetActive(true);
        }
    }
}

