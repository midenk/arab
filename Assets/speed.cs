using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    public GameObject boots;
    private AudioSource pickboot;

    void Start()
    {
        StartCoroutine(CreateBoots());
        pickboot = GetComponent<AudioSource>();
        pickboot.Stop();
    }
    private IEnumerator CreateBoots()
    {
        yield return new WaitForSeconds(Random.Range(2,10));
        boots.transform.position = new Vector3(19f, Random.Range(-3.18f, 5.5f));
    }
    // Update is called once per frame
    void Update()
    {
       boots.transform.position += new Vector3(pipescode.speed, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "boost")
        {
            pipescode.speed -= 0.01f;
        }
        collision.gameObject.SetActive(false);
        pickboot.Play();
    }
}
