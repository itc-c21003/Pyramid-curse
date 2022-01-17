using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    public bool[] Key = new bool[6];
    public int GetCount;
    
    // Start is called before the first frame update
    void Start()
    {
        //フレームレート固定
        Application.targetFrameRate = 30;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
