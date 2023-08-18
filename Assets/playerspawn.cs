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
            PhotonNetwork.Instantiate("Player", new Vector3(0.8593892f, 0.303198f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
