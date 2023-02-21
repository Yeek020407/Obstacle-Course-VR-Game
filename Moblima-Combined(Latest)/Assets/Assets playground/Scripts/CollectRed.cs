using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectRed : MonoBehaviour
{
   	public AudioClip collectAlot;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
	{
        AudioSource.PlayClipAtPoint(collectAlot, transform.position);
        ScoringSystem.theScore += 200;
        Destroy(gameObject);
    }
}
