using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject m_player;
    private NavMeshAgent m_enemyAgent;

    void Start()
    {
        m_enemyAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        m_enemyAgent.destination = m_player.transform.position;
    }
}
