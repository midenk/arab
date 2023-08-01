using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class palma : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI textMeshProUGUI;
    public void Button1()
    {
        string str = inputField.text;
        int g = str.Length - 1;
        for(int i = 0; i < str.Length / 2; i++)
        {
            if (str[g] == str[i])
            {
                g--;
                textMeshProUGUI.text = "является";
            }
            else
            {
                textMeshProUGUI.text = "не является";
                break;
            }
        }
    }
}
