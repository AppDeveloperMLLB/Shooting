using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
    Zombi zombi;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
        Debug.Log("Start");
        zombi = GetComponent<Zombi>();
    }

    // Update is called once per frame
    void Update()
    {
        if (zombi.shouldStop)
        {
            return;
        }

        agent.destination = player.transform.position;
    }
}
