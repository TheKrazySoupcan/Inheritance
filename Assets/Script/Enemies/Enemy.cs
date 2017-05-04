using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    [Header("Enemy")]
    public float damage = 50f;
    public float health = 100f;
    public float movementSpeed = 20f;
    public float stoppingDistance = 2f;
    public Transform target;
    public NavMeshAgent agent;


    void Awake()
    {

        agent = GetComponent<NavMeshAgent>();
    }

    protected void SeekToTarget ()
    {
       if (target != null)
        {
            agent.stoppingDistance = stoppingDistance;
            agent.SetDestination(target.position);
        }
    }

    protected bool IsAtTarget ()
    {
        return agent.remainingDistance <= agent.stoppingDistance;
    }

    
}
