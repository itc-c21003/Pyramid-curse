using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSun : MonoBehaviour
{
  public int KeyNumber;
  public GetKey getKey;
  public GameObject Enemy;
  public Vector3 popArea;
  public Vector3 GollArea1;
  public Vector3 GollArea2;
  public GameObject Goll;
  public GameObject[] sekibann;
    void Start()
    {
        sekibann[0].SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
 {
    if (other.gameObject.tag == "Player")
    {
        getKey.Key[KeyNumber] = true;
        Destroy(this.gameObject);
        sekibann[0].SetActive(true);
        sekibann[1].SetActive(false);
        sekibann[2].SetActive(false);
            if (getKey.Key[4] && getKey.Key[5])
            {
                Instantiate(Enemy, popArea, Quaternion.identity);
                Instantiate(Goll, GollArea1, Quaternion.identity);
                Instantiate(Goll, GollArea2, Quaternion.identity);
            }
        }
 }
}
