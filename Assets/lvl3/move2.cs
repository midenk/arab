using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class move2 : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.position += Vector3.up * Time.deltaTime * 4;
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.position += Vector3.down * Time.deltaTime * 4;
        //}
        if(ball.transform.position.y < transform.position.y)
        {
            transform.position += Vector3.down * Time.deltaTime * 4;
        }
        if (ball.transform.position.y > transform.position.y)
        {
            transform.position += Vector3.up * Time.deltaTime * 4;
        }
    }
}
