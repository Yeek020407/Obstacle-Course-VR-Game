using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIZombie : MonoBehaviour
{
   public GameObject player;
   public float fov = 120f;
   public float viewDistance = 10f;
   private bool isAware = false;
   private NavMeshAgent agent;
   private Animator animator;
   public float zombieSpeed = 2f;

   public void Start()
   {
      agent = GetComponent<NavMeshAgent>();
      animator = gameObject.GetComponent<Animator>();
   }
   public void Update()
   {
   		if(isAware)
   		{
   			agent.SetDestination(player.transform.position);
            animator.SetBool("Aware", true);
            agent.speed = zombieSpeed;
   		}else
   		{
   			SearchForPlayer();
   		}
   }
   public void SearchForPlayer()
   {
   		if (Vector3.Angle(Vector3.forward, transform.InverseTransformPoint(player.transform.position)) < fov / 2f)
   		{
   			if(Vector3.Distance(player.transform.position, transform.position) < viewDistance)
   			{
   				OnAware();
   			}	
   		}
   }
   
   public void OnAware()
   {
   		isAware	= true;
   }
}
