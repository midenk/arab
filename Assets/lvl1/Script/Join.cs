using JetBrains.Annotations;
using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Join : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
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
    void Update()
    {
        
    }
}
