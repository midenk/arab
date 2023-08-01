using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class playerspawn : MonoBehaviour
{
    
    void Start()
    {
        if (PhotonNetwork.InRoom)
        {
            PhotonNetwork.Instantiate("Player", new Vector3(-223.0632f, -83.37817f, -121.5085f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
