using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pipetouch : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private TextMeshProUGUI count;
    [SerializeField] private GameObject failure;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            pipescode.counting++;
            count.text = pipescode.counting.ToString();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject== player)
        {
            failure.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
