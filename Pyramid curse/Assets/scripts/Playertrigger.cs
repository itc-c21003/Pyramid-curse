using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playertrigger : MonoBehaviour
{
    public Scenechange Scenechange;
    public BGM GM;
    public int Hitcount;
    public GameObject[] Life;
    bool hit; public float resetTime;
    public bool Found;
    Vector3 startpos;
    // Start is called before the first frame update
    void Start()
    {      
        Found = false;
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(hit) reset();    
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!hit)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                count();
                this.transform.position = startpos;
            }
        }
    }
    private void count()
    {
        if (Hitcount == 2) Scenechange.GaveOver();
        else
        {
            if (!hit)
            {
                hit = true;
                Life[Hitcount].SetActive(false);
                Hitcount++;
                TrackingEnd();
            }
        }
    }
    void reset() 
    {
        resetTime += Time.deltaTime;
        if (resetTime > 1) 
        {
            hit = false;
            resetTime = 0;
        }
    }
    void trackingbgm()
    {
        GM.Ac1(); Found = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goll")
        { Scenechange.GAMECLEAR(); }
                
        if (other.gameObject.tag == "searchArea")
        {
            //å©Ç¬Ç©Ç¡ÇƒÇ¢ÇÈèÛë‘Ç»ÇÁBGMÇïœÇ¶ÇÈ
            if (!Found)
            {
                trackingbgm();
            }
            if (Found) CancelInvoke();
        }
    }
    void TrackingEnd()
    {
        Found = false; GM.Ac0();
        CancelInvoke();
    }
    private void OnTriggerExit(Collider other)
    {
        if(Found)
        {
            if (other.tag == "searchArea")
            {
                Invoke("TrackingEnd", 2);
            }
        }
    }
}
