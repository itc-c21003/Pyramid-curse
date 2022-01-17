using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollow : MonoBehaviour
{
    public GameObject target;
    public float followSpeed;
    void Start()
    {

    }
    private void LateUpdate()
    {

        transform.position = new Vector3(target.transform.position.x, 10, target.transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {

    }
}