using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winscript : MonoBehaviour
{
    public GameObject player;
    public GameObject lvlwin;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            lvlwin.SetActive(true);
        }
    }
}