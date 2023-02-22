using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welcome : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject welcome;
    public AudioClip collectSound;
    public AudioSource bgm;
    public AudioClip bgm2;
    void OnTriggerStay(Collider col){
        if(col.tag == "Player"){
            welcome.SetActive(true);

        }
    }

    void OnTriggerEnter(Collider col){
        if(col.tag == "Player"){
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        }
    }

    void OnTriggerExit(Collider col){
        if(col.tag == "Player"){
            welcome.SetActive(false);
            
            bgm.Play();

        }
    }

}


