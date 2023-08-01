using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1.0f;
                GetComponent<TextMeshProUGUI>().text = "";
            }
            else
            {
                Time.timeScale = 0;
                GetComponent<TextMeshProUGUI>().text = "Пауза";
            }

        }
        
    }
}
