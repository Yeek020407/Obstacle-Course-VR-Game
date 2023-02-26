using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class congrats : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject congrat;
    public AudioClip collectSound;
    public AudioSource bossBattle;
    
    void OnTriggerEnter(Collider col){
        if(col.tag == "Player"){
            congrat.SetActive(true);
            bossBattle.Stop();
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        }
    }
}

