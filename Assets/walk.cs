using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Pun.Demo.Cockpit;

public class walk : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public float speed;
    Animator animator;
    Rigidbody2D rigidbody;
    public float jumpforce = 3f;
    public TextMeshPro name;
    PhotonView photonView;
    public Camera camera;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
        photonView= GetComponent<PhotonView>();
        name.text = PhotonNetwork.NickName;
        if (!photonView.IsMine)
        {
            camera.enabled = false;
        }
    }

    void Update()
    {
        
        if (!photonView.IsMine)
        {
            return;
        }

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
        photonView.RPC("Data", RpcTarget.All, spriteRenderer.flipX, name.text);
    }
    [PunRPC]
    void Data(bool flipping, string nameNick)
    {
        if (spriteRenderer == null)
        {
            return;
        }
        spriteRenderer.flipX = flipping;
        name.text = nameNick;
    }
}
