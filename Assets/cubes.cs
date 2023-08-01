using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cubes : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float test = 0f;
        if (plane.Raycast(ray, out test))
        {
            Vector3 vct = ray.GetPoint(test);
            transform.position = vct;
        }
    }
}
