using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class balls : MonoBehaviour
{
    public static float speed = 3f;
    private int scoreLeft = 0;
    private int scoreRight = 0;
    [SerializeField] private GameObject win;
    [SerializeField] private GameObject lose;
    [SerializeField] private TextMeshProUGUI countLeft;
    [SerializeField] private TextMeshProUGUI countRight;
    [SerializeField] private TextMeshProUGUI result;
    private float currentSpeed = speed;
    private float angle = 0;
    void Start()
    {

    }
    void Update()
    {
        transform.Translate(new Vector3(currentSpeed, angle, 0) * Time.deltaTime);
        if(scoreLeft == 5)
        {
            win.SetActive(true);
            Time.timeScale = 0;
        }
        if(scoreRight == 5)
        {
            lose.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Egg2")
        {
            if (Mathf.Abs(currentSpeed) < 5)
            {
                currentSpeed *= 1.1f;
            }
            currentSpeed = -currentSpeed;
            angle = Random.Range(-currentSpeed, currentSpeed);
        }
        if (collision.gameObject.tag == "Egg")
        {
            if (Mathf.Abs(currentSpeed) < 5)
            {
                currentSpeed *= 1.1f;
            }
            currentSpeed = -currentSpeed;
            angle = Random.Range(-currentSpeed, currentSpeed);
        }
        if (collision.gameObject.tag == "Edge1")
        {
            angle = -angle;
        }
        if (collision.gameObject.tag == "Edge2")
        {
            angle = -angle;
        }
        if(collision.gameObject.tag == "WinLeft")
        {
            currentSpeed = -currentSpeed;
            transform.position = new Vector3(0, 0, 0);
            scoreLeft++;
            countLeft.text = scoreLeft.ToString();
        }
        if (collision.gameObject.tag == "WinRight")
        {
            transform.position = new Vector3(0, 0, 0);
            currentSpeed = -currentSpeed;
            scoreRight++;
            countRight.text = scoreRight.ToString();
        }
    }
}
