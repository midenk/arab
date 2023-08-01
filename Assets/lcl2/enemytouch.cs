using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class enemytouch : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private TextMeshProUGUI count;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            pipescode.counting -= 1;
            count.text = pipescode.counting.ToString();
            gameObject.SetActive(false);
        }
    }
}
