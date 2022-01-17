using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Tracking : MonoBehaviour
{
    [SerializeField] private EnemyMove enemyMove;
    void Start()
    {

    }
    void Update()
    {

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Invoke("TrackingEnd",2);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            if (enemyMove.tracking) CancelInvoke();
            if (!enemyMove.tracking)
            { 
                enemyMove.tracking = true;
            }
        }
    }
    void TrackingEnd()
    {
        enemyMove.tracking = false;
    }
}
