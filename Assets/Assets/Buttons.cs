using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using TMPro;
using Photon.Realtime;

public class Buttons : MonoBehaviourPunCallbacks
{
   public TMP_InputField name;
    public override void OnConnectedToMaster()
    {
        RoomOptions roomOptions = new RoomOptions();
        PhotonNetwork.JoinOrCreateRoom(" barabara", roomOptions, TypedLobby.Default);
        Debug.Log("join");
    }

    public override void OnCreatedRoom()
    {
        Debug.Log("create");
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("joinn");
        PhotonNetwork.LoadLevel("lvl4");
    }
    public void Play()
    {
        PhotonNetwork.NickName = name.text;
        PhotonNetwork.ConnectUsingSettings();   
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
