using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public GameObject buttons;
    public float jump = 30.0f;
    public float speed = 1.0f;
    private float timer = 0;
    public bool bull = false;
    private float horizontal;
    public bool isGround = true;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bull)
        {
            timer += Time.deltaTime;
            if (timer > 0.5)
            {
                horizontal = 0;
                timer = 0;
                bull= false;
            }
        }

    }
    void FixedUpdate()
    {

#if UNITY_STANDALONE
        horizontal = Input.GetAxis("Horizontal");
        buttons.SetActive(false);
        if (Input.GetButton("Jump") && isGround)
        {
            rb.AddForce(transform.up * jump);
            isGround= false;
        }

#elif UNITY_ANDROID || UNITY_IOS
        buttons.SetActive(true);

        if (Input.GetMouseButtonDown(0) && isGround)
        {
            rb.AddForce(transform.up * jump);
            isGround = false;
        }
#endif
        Vector3 movementDirection = new Vector3(horizontal, 0);
        transform.position += movementDirection * speed * Time.deltaTime;
    }
    public void Right()
    {
        horizontal = 1;
        bull = true;
    }


    public void Left()
    {
        horizontal = -1;
        bull = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ударился");
        if (collision.gameObject.tag == "Ground") 
        {
            isGround = true;
        }


    }
}  