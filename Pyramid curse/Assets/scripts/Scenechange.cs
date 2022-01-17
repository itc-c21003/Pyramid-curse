using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenechange : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TitleScene()
    {
        SceneManager.LoadScene("title");
    }    
    public void MainScene()
    {
        SceneManager.LoadScene("Main");
    }   
    public void GaveOver()
    {
        SceneManager.LoadScene("GameOver");
    }    
    public void GAMECLEAR()
    {
        SceneManager.LoadScene("GAMECLEAR");
    } 
}
