using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject enem;
    public static int counting = 0;
    private List<GameObject> list;
    void Start()
    {
        list = new List<GameObject>
        {
            Instantiate(enem)
        };
        StartCoroutine("CreateEnemy");
        StartCoroutine("DeleteEnemy");
    }
    public IEnumerator CreateEnemy()
    {
        float[] mas = { 5.55f,4.11f,-2.38f};
        while (true)
        {
            yield return new WaitForSeconds(4);
            list.Add(Instantiate(enem));
            list[list.Count - 1].transform.position = new Vector3(26, mas[Random.Range(0, mas.Length)], 0);
        }

    }
    public IEnumerator DeleteEnemy()
    {
        yield return new WaitForSeconds(5);
        while (true)
        {
            if(list.Count > 3)
            {
                Destroy(list[0]);
                list.RemoveAt(0);
            }
            yield return new WaitForSeconds(1);
        }
    }
    void Update()
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i].transform.position += new Vector3(pipescode.speed, 0, 0);
        }
    }
}
