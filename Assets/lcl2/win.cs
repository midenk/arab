using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    public GameObject player;
    public GameObject lvlwin;
    public void Update()
    {
        if (pipescode.counting == 1)
        {
            lvlwin.SetActive(true);
            Time.timeScale = 0;
        }
    }
}