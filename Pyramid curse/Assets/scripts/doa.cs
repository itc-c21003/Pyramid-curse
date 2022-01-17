using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doa : MonoBehaviour
{
    public GetKey getKey;
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && getKey.Key[number])
        {
            Destroy(this.gameObject);
        }
    }
}
