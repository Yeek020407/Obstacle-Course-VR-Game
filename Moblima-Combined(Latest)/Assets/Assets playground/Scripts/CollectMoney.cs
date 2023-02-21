using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectMoney : MonoBehaviour
{	
	public AudioClip collectSound;

    void OnTriggerEnter(Collider other)
    {
    	AudioSource.PlayClipAtPoint(collectSound, transform.position);
    	ScoringSystem.theScore += 50;
    	Destroy(gameObject);
    }
}
