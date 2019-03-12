﻿using UnityEngine;
using UnityEngine.AI;

public class EnemyPathing : MonoBehaviour
{

    public Transform player;

    public NavMeshAgent nav;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
    }
}
