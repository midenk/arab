using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipescode : MonoBehaviour
{
    public GameObject pipe;
    public static float speed = -0.1f;
    public static int counting = 0;
    private List<GameObject> list;
    void Start()
    {
        list = new List<GameObject>
        {
            Instantiate(pipe)
        };
        StartCoroutine("CreatePipe");
        StartCoroutine("DeletePipe");
        counting= 0;
    }
    public IEnumerator CreatePipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            list.Add(Instantiate(pipe));
            list[list.Count - 1].transform.position = new Vector3(26, Random.Range(-2.63f, 3.31f), 0);
        }

    }
    public IEnumerator DeletePipe()
    {
        while (true)
        {
            if(list.Count > 5)
            {
                Destroy(list[0]);
                list.RemoveAt(0);
            }
            yield return new WaitForSeconds(1);
        }
    }
    void Update()
    {
        for(int i = 0; i < list.Count; i++)
        {
            list[i].transform.position += new Vector3(speed, 0, 0);
        }
    }
}
