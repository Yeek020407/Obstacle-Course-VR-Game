using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Assertions;

    public class KillZone : MonoBehaviour
    {   
        public Transform checkpoint;
        public GameObject xrOrigin;
        public float speed;
        private bool correctPos = true;
        

        void OnTriggerEnter(Collider col)
        {
            if(col.tag=="Player"){
                correctPos = false;
                xrOrigin.GetComponent<Jump>().enabled = false;
                xrOrigin.GetComponent<CharacterControllerGravity>().enabled = false;

            }
        }

        private void Update(){
            if(!correctPos){
                if(Vector3.Distance(xrOrigin.transform.position, checkpoint.position) < 1.0){
                    correctPos = true;
                    xrOrigin.GetComponent<Jump>().enabled = true;
                    xrOrigin.GetComponent<CharacterControllerGravity>().enabled = true;
                    return;
                }

                
                float step = Time.deltaTime * speed;
                xrOrigin.transform.position = Vector3.MoveTowards(xrOrigin.transform.position, checkpoint.position, step);
            }
            
        }
    }
    