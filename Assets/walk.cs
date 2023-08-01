using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public float speed;
    Animator animator;
    Rigidbody2D rigidbody;
    public float jumpforce = 3f;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        float walk = Input.GetAxis("Horizontal");
        animator.SetFloat("walk", Mathf.Abs(walk));
        transform.position += new Vector3(walk, 0, 0) * Time.deltaTime * speed;
        if(walk < 0)
        {
            spriteRenderer.flipX = false;
        }
        if(walk > 0)
        {
            spriteRenderer.flipX = true;
        }
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(Vector3.up * jumpforce, ForceMode2D.Impulse);
        }
    }
}
