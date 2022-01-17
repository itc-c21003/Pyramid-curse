using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holywater : MonoBehaviour
{
    public GameObject Water;
    public int shotForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
           //オブジェクトのRigidBodyを取得し力と回転を加える
           Rigidbody toolRigidbody =GetComponent<Rigidbody>();
           toolRigidbody.AddForce(transform.forward * shotForce);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "yuka")
        {
            Destroy(this.gameObject);
            Instantiate(Water,new Vector3( transform.position.x,0,transform.position.z), Quaternion.identity);
        }
    }
}
