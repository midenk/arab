using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        float vertical = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(0, vertical);
        transform.position += movementDirection * speed * Time.deltaTime;
    }
}
