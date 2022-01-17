using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour
{
    public int KeyNumber;
    public GetKey getKey;
    public GameObject[] Enemy;
    public Vector3 popArea;
    public GameObject sekibann;
    void Start()
    {
        sekibann.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            getKey.Key[KeyNumber] = true;
            Destroy(this.gameObject);
            getKey.GetCount++; 
            sekibann.SetActive(true);
          if(getKey.GetCount == 2) Instantiate(Enemy[0],popArea,Quaternion.identity);
          if(getKey.GetCount == 4) Instantiate(Enemy[1],popArea,Quaternion.identity); 
        }
    }
}
