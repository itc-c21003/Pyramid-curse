using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tools : MonoBehaviour
{
    public GameObject[] tools;
    public int toolnumber; 
    public int[] tool;
    public Text ToolText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("x")) Set();
        if (Input.GetKeyDown("z")) Down();
        if (Input.GetKeyDown("c")) Up();
        ToolText.text = "Tool" + toolnumber + " x" +tool[toolnumber];
    }
    public void Up()
    {
        if (toolnumber != tool.Length - 1) toolnumber++;
        else toolnumber = 0;
    }
    public void Down()
    {
        if (toolnumber != 0) toolnumber--;
        else toolnumber = tool.Length - 1;
    }
    public void Set()
    {
        //選択されたアイテムの数が０なら使用しない
        if (tool[toolnumber] != 0)
        {
            //選択されたアイテムを使用し数を減らす
            Instantiate(tools[toolnumber], transform.position, Quaternion.identity);
            tool[toolnumber]--;
        }
    }
}
