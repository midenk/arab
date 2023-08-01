using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycreate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit, 200f))
        {
            Debug.Log(hit.collider.name);
            if(hit.transform.GetComponent<Renderer>().material.color == Color.red)
            {
                hit.transform.GetComponent<Renderer>().material.color = Color.blue;
            }
            else
            {
                hit.transform.GetComponent<Renderer>().material.color = Color.green;
            }
        }
    }
}
