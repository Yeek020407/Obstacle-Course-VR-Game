using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Assertions;
// namespace UnityEngine.XR.Interaction.Toolkit{
//     public class KillZone : LocomotionProvider
//     {   
//         public Transform checkpoint;
//         void OnTriggerEnter(Collider col)
//         {
//             {
//                 var xrOrigin = system.xrOrigin;
//                 xrOrigin.MoveCameraToWorldLocation(checkpoint.transform.position);

            


//                 // GameObject varGameObject = GameObject.Find("XR Origin");  
//                 // GameObject varGameObject1 = GameObject.Find("Camera Offset");
//                 // GameObject varGameObject2 = GameObject.Find("Main Camera");
//                 // GameObject varGameObject3 = GameObject.Find("LeftHand Controller");
//                 // GameObject varGameObject4 = GameObject.Find("RightHand Controller");

//                 // xrOrigin.transform.position = checkpoint.transform.position;
//                 // varGameObject.transform.position = checkpoint.transform.position;
//                 // Debug.LogError(varGameObject.transform.position);
//                 // camera1.transform.position = checkpoint.transform.position;
//                 // varGameObject1.transform.position = checkpoint.transform.position;
//                 // Debug.LogError(varGameObject1.transform.position);
//                 // varGameObject2.transform.position = checkpoint.transform.position;
//                 // varGameObject3.transform.position = checkpoint.transform.position;
//                 // varGameObject4.transform.position = checkpoint.transform.position;


//             }
//         }
//     }
// }
    public class KillZone : MonoBehaviour
    {   
        public Transform checkpoint;
        public GameObject xrOrigin;
        public Camera camera1;
        void OnTriggerEnter(Collider col)
        {
            {

                GameObject varGameObject = GameObject.Find("XR Origin");  
                GameObject varGameObject1 = GameObject.Find("Camera Offset");
                GameObject varGameObject2 = GameObject.Find("Main Camera");
                GameObject varGameObject3 = GameObject.Find("LeftHand Controller");
                GameObject varGameObject4 = GameObject.Find("RightHand Controller");

                xrOrigin.transform.position = checkpoint.transform.position;
                Debug.LogError(varGameObject.transform.position);
                camera1.transform.position = checkpoint.transform.position;
                // varGameObject1.transform.position = checkpoint.transform.position;
                // Debug.LogError(varGameObject1.transform.position);
                // varGameObject2.transform.position = checkpoint.transform.position;
                // varGameObject3.transform.position = checkpoint.transform.position;
                // varGameObject4.transform.position = checkpoint.transform.position;


            }
        }
    }
    



