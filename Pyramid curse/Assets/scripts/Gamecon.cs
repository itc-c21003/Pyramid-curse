using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecon : MonoBehaviour
{
    public GameObject Panel;
    public GameObject PausePanel;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;//フレームレート固定
        Panel.SetActive(true);
        PausePanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            Panel.SetActive(false);
            PausePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            Panel.SetActive(true);
            PausePanel.SetActive(false);
        }
    }
}
