using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class lvlexit : MonoBehaviour
{
    public GameObject exitlvl;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1.0f;
                exitlvl.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                exitlvl.SetActive(true);
            }
        }
    }
}
