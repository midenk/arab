using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fps : MonoBehaviour
{
    public static float fps;

    private void OnGUI()
    {
        fps = 1.0f / Time.deltaTime;
        GUILayout.Label("FPS:" + (int)fps);
    }
}
