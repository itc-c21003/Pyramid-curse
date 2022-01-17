using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPop : MonoBehaviour
{
    public int count;
    public List<GameObject> Pop = new List<GameObject>();
    public List<GameObject> Key;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i <= count; i++)
        {
            int RP = Random.Range(0, Pop.Count);
            int RK = Random.Range(0, Key.Count);
            Key[RK].transform.position = Pop[RP].transform.position;
            Key.RemoveAt(RK);  Pop.RemoveAt(RP);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
