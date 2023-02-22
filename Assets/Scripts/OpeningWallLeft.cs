using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningWallLeft : MonoBehaviour
{
	public float distance = 5f; //Distance that moves the object
	public bool horizontal = true; //If the movement is horizontal or vertical
	public float speed = 3f;
	public float offset = 0f; //If yo want to modify the position at the start 

	private bool isForward = true; //If the movement is out
	private Vector3 startPos;

	public GameObject closingWall2;
   
    void Awake()
    {
		startPos = closingWall2.transform.position;
		if (horizontal)
			closingWall2.transform.position += Vector3.left * offset;
		else
			closingWall2.transform.position += Vector3.forward * offset;
	}

    // Update is called once per frame
    void OnTriggerStay(Collider col)
    {
		if(col.tag == "Player")
		{
			if (horizontal)
			{
				if (isForward)
				{
					if (closingWall2.transform.position.x < startPos.x + distance)
					{
						closingWall2.transform.position += Vector3.left * Time.deltaTime * speed;
					}
					else
						isForward = false;
				}
				else
				{
					if (closingWall2.transform.position.x > startPos.x)
					{
						closingWall2.transform.position -= Vector3.left * Time.deltaTime * speed;
					}
					else
						isForward = true;
				}
			}
			else
			{
				if (isForward)
				{
					if (closingWall2.transform.position.z < startPos.z)
					{
						closingWall2.transform.position += Vector3.forward * Time.deltaTime * speed;
					}
				}
				else
				{
					if (closingWall2.transform.position.z < startPos.z)
					{
						closingWall2.transform.position += Vector3.forward * Time.deltaTime * speed;
					}
					else
						isForward = true;
				}
			}
		}
    }
}
