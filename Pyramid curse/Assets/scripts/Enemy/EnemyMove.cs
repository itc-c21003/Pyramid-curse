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
        //�ォ�瑝�����G��p
        if (pp == null) { pp = GameObject.FindGameObjectWithTag("Player"); }
        //�ʏ�
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
        //Player�̋����𑪂�
        playerPos = pp.transform.position;
        
        if (tracking)
        {
            //Player��ڕW�Ƃ���
            agent.destination = playerPos;
        }
        if (!tracking)
        {
            // �G�[�W�F���g�����ڕW�n�_�ɋ߂Â��Ă�����A���̖ڕW�n�_��I��
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
        }
    }
    public void GotoNextPoint()
    {
        // �n�_���Ȃɂ��ݒ肳��Ă��Ȃ��Ƃ��ɕԂ�
        if (targetpoints.Length == 0)
            return;

        // �G�[�W�F���g�����ݐݒ肳�ꂽ�ڕW�n�_�ɍs��
        agent.destination = targetpoints[Point];
        // �z����̎��̈ʒu��ڕW�n�_�ɐݒ肵�A �K�v�Ȃ�Ώo���n�_�ɖ߂�
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
