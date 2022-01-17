using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public bool tracking = false; int Point;
    Vector3 playerPos;
    public GameObject pp;
    public int targetpointX;public int targetpointZ1;public int targetpointZ2;
    Vector3[] targetpoints = new Vector3[4];
    private NavMeshAgent agent;
    public int speed;
    
    void Start()
    {
        //後から増えた敵専用
        if (pp == null) { pp = GameObject.FindGameObjectWithTag("Player"); }
        //通常
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        agent.autoBraking = false;
        targetpoints[0] = new Vector3(targetpointX, 0, targetpointZ1);
        targetpoints[1] = new Vector3(-targetpointX, 0, targetpointZ1);
        targetpoints[2] = new Vector3(-targetpointX, 0, targetpointZ2);        
        targetpoints[3] = new Vector3(targetpointX, 0, targetpointZ2);
        GotoNextPoint();
    }
    void LateUpdate()
    {
        //Playerの距離を測る
        playerPos = pp.transform.position;
        
        if (tracking)
        {
            //Playerを目標とする
            agent.destination = playerPos;
        }
        if (!tracking)
        {
            // エージェントが現目標地点に近づいてきたら、次の目標地点を選択
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
        }
    }
    public void GotoNextPoint()
    {
        // 地点がなにも設定されていないときに返す
        if (targetpoints.Length == 0)
            return;

        // エージェントが現在設定された目標地点に行く
        agent.destination = targetpoints[Point];
        // 配列内の次の位置を目標地点に設定し、 必要ならば出発地点に戻る
        Point = (Point + 1) % targetpoints.Length;
    }
    void Update()
    {
          
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
                tracking = false;           
        }
    }
}
