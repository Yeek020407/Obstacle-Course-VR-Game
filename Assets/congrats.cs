using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class congrats : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject congrat;
    public AudioClip collectSound;
    
    void OnTriggerStay(Collider col){
        if(col.tag == "Player"){
            congrat.SetActive(true);
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        }
    }
}

