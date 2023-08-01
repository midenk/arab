using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlchosing : MonoBehaviour
{
    public void One()
    {
        SceneManager.LoadScene("lvl1");
    }

    public void Two()
    {
        SceneManager.LoadScene("lvl2");
    }
    public void Three()
    {
        SceneManager.LoadScene("lvl3");
    }



}
