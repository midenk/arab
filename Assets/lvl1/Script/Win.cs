using System;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject player;
    public GameObject timer;
    public GameObject leaderboard;
    
    public float[] spisok;
    private float time = 0, minute = 0, second = 0;

    public void Start()
    {

    }
    public void Update()
    {
        TextMeshProUGUI timerText = timer.GetComponent<TextMeshProUGUI>();
        time += Time.deltaTime;
        minute = Convert.ToInt32(time /60);
        second = Convert.ToInt32(time % 60);
        timerText.text = minute.ToString() + ":" + second.ToString();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            spisok = new float[5];
            spisok[0] = PlayerPrefs.GetFloat("spisok1",60);
            spisok[1] = PlayerPrefs.GetFloat("spisok2",70);
            spisok[2] = PlayerPrefs.GetFloat("spisok3",80);
            spisok[3] = PlayerPrefs.GetFloat("spisok4",90);
            spisok[4] = PlayerPrefs.GetFloat("spisok5",100);
            Debug.Log("победа");
            Time.timeScale = 0;
            if (spisok[4] > time)
            {
                spisok[4] = time;
            }
            Array.Sort(spisok);
            PlayerPrefs.SetFloat("spisok1", spisok[0]);
            PlayerPrefs.SetFloat("spisok2", spisok[1]);
            PlayerPrefs.SetFloat("spisok3", spisok[2]);
            PlayerPrefs.SetFloat("spisok4", spisok[3]);
            PlayerPrefs.SetFloat("spisok5", spisok[4]);
            string pmgr = string.Empty;
            for(int i = 0; i < spisok.Length; i++)
            {
                pmgr += $"{i + 1}. {spisok[i]}\n";
            }
            TextMeshProUGUI leaderboardText = leaderboard.GetComponent<TextMeshProUGUI>();
            leaderboardText.text = pmgr;
        }
    }
 
    
}
