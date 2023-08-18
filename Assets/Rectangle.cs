using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour
{
    private float width;
    private float height;
    public Rectangle(float width, float height)
    {
        this.width = width;
        this.height = height;
    }
    public override string ToString()
    {
        return $"Прямоугольник {width} x {height}";
    }
}
