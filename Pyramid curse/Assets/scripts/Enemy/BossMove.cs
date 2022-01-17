using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class BossMove : MonoBehaviour
{
    Vector3 playerPos; public int speed;
    private NavMeshAgent agent;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false; 
        player = GameObject.FindGameObjectWithTag("Player");
        agent.speed = speed;       
    }
    private void LateUpdate()
    {
        playerPos = player.transform.position;
        agent.destination = playerPos;
    }
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.position = new Vector3(0, 0, -15);
        }
    }
}
