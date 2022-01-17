using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioSource audios;
    public AudioSource ASE;
    public AudioClip[] AC;
    // Start is called before the first frame update
    void Start()
    {
        audios = GetComponent<AudioSource>();
        //配列変数clipのインデックスが０のAudioのファイルを再生します。
        Ac0();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Ac0()
    {
        audios.clip = AC[0];
        audios.Play();
    } 
    public void Ac1()
    {
        audios.clip = AC[1];
        audios.Play();
    }
    public void Ac2()
    {
        ASE.PlayOneShot(AC[2]);
    }
    public void Ac3()
    {
        ASE.PlayOneShot(AC[3]);
    }
}
