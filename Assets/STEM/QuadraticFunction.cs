using UnityEngine;

public class QuadraticFunction
{
    public float a = 1f;
    public float b = 1f;
    public float c = 1f;

    public float getY(float x)
    {
        return a * x * x + b * x + c;
    }
}

