using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using TMPro;

public class Buttons : MonoBehaviour
{
   public TMP_InputField name;
   public void Play()
    {
        PhotonNetwork.NickName = name.text;
        SceneManager.LoadScene("lvl4");
    }
   public void Continue()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("continue"));
        Time.timeScale = 1;
    }
   public void Exit()
    {
        Application.Quit();
    }
   public void Settings()
    {

    }
    public void Levelchose()
    {
        SceneManager.LoadScene("levelchange");
    }
    public void Menuexit()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1.0f;
    }
    public void NextLevel1()
    {
        SceneManager.LoadSceneAsync("lvl2");
        Time.timeScale= 1.0f;
    }
    public void RestartLevel1()
    {
        SceneManager.LoadScene("lvl1");
        Time.timeScale = 1.0f;
    }
    public void NextLevel2()
    {
        SceneManager.LoadScene("lvl3");
        Time.timeScale = 1.0f;
    }
    public void NextLevel3()
    {
        SceneManager.LoadScene("lvl4");
        Time.timeScale = 1.0f;
    }
}   
