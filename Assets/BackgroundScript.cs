using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(pipescode.speed, 0, 0);
        if(transform.position.x < -17)
        {
            transform.position += new Vector3(34, 0, 0);
        }
    }
}
