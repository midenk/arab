using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enter : MonoBehaviour
{
    Dictionary<string, string> logpass;
    public TMP_InputField login;
    public TMP_InputField password;
    void Start()
    {
        logpass = new Dictionary<string, string>()
        {
            {"login", "password" }, {"admin", "12345" }, {"ad", "12345"}
        };
        foreach(var item in logpass)
        {
            Debug.Log(item);
        }
    }
    public void Enter()
    {
        foreach(var item in logpass)
        {
            if(login.text == item.Key && password.text == item.Value)
            {
                SceneManager.LoadScene("lvl4");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
