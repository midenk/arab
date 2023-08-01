using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    public GameObject player;
    public GameObject lose;

    public void Start()
    {
        lose.SetActive(false);
    }
    public void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("проиграл");
            lose.SetActive(true);
            TextMeshProUGUI winText = lose.GetComponent<TextMeshProUGUI>();
            winText.text = "Поражение";
            Time.timeScale = 0;
        }
    }


}