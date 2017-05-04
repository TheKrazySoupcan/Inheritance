using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Boomer : Enemy
{
    [Header("boomer")]
    public SphereCollider explosionSphere;
    public GameObject onSelfDestruct;

    void Update ()
    {
        SeekToTarget();
    }

  void FixedUpdate()
    {


    }

    void SelfDestruct()
    {
        PlayExplosion();
    }

    void PlayExplosion()
    {
        GameObject explosion = Instantiate(onSelfDestruct);
        explosion.transform.position = transform.position;
    }

    void Explode()
    {
        // Detect collision with others

    }
}
