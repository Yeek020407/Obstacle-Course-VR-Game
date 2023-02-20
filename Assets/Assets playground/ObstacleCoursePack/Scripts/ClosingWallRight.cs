using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingWallRight : MonoBehaviour
{
	public float distance; //Distance that moves the object
	public bool horizontal = true; //If the movement is horizontal or vertical
	public float speed = 3f;
	

	private bool isForward = true; //If the movement is out
	private Vector3 startPos;

	public GameObject closingWall1;
   
    void Awake()
    {
		startPos = closingWall1.transform.position;
	}

    // Update is called once per frame
    void OnTriggerStay(Collider col)
    {
		if(col.tag == "Player"){
			if (horizontal)
			{
				if (isForward)
				{
					if (closingWall1.transform.position.x < startPos.x + distance)
					{
						closingWall1.transform.position += Vector3.right * Time.deltaTime * speed;
					}
					else
						isForward = false;
				}
				else
				{
					if (closingWall1.transform.position.x > startPos.x)
					{
						closingWall1.transform.position -= Vector3.right * Time.deltaTime * speed;
					}
					else
						isForward = true;
				}
			}
			else
			{
				if (isForward)
				{
					if (closingWall1.transform.position.z < startPos.z + distance)
					{
						closingWall1.transform.position += Vector3.forward * Time.deltaTime * speed;
					}
				}
				else
				{
					if (closingWall1.transform.position.z > startPos.z)
					{
						closingWall1.transform.position -= Vector3.forward * Time.deltaTime * speed;
					}
					else
						isForward = true;
				}
			}
		}
		
    }
	void OnTriggerExit(Collider col){
		if(col.tag=="Player"){

			transform.position = startPos;
		}
	}
}
