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
        public bool open;
        private bool correctPos = true;
        public float timeRemaining=3.0f;
        public GameObject gameOverText;
        public AudioSource gameOverBGM;
        

        void OnTriggerEnter(Collider col)
        {
            if(col.tag=="Player"){
                correctPos = false;
                timeRemaining = 5.0f;
                xrOrigin.GetComponent<Jump>().enabled = false;
                xrOrigin.GetComponent<CharacterControllerGravity>().enabled = false;
                open = true;
                gameOverBGM.Play();
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

            if(open){
                timeRemaining-= Time.deltaTime;
                gameOverText.SetActive(true);
                gameOverText.transform.position = new Vector3(checkpoint.position.x -15.0f,checkpoint.position.y +3.0f, checkpoint.position.z);
            }

            if(timeRemaining<0){
                open = false;
                gameOverText.SetActive(false);
            }


            
        }
    }
    