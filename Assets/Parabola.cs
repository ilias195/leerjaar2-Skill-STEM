using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Parabola : MonoBehaviour
{
    [SerializeField] GameObject point;
    Vector2 minScreen, maxScreen;
    int numberOfPoints = 100;

    [SerializeField] public float a = 1f;
    [SerializeField] public float b = 2f;
    [SerializeField] public float c = -3f;

    QuadraticFunction f;

    void Start()
    {
        f = new QuadraticFunction();
        minScreen = (Camera.main.ScreenToWorldPoint(Vector2.zero));
        maxScreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        float dx = (maxScreen -  minScreen).x / numberOfPoints;

        for (int i = 0; i < numberOfPoints; i++)
        {
            GameObject pointCopy = Instantiate(point);
            float x = minScreen.x  + i * dx;
            float y = f.getY(x);
            pointCopy.transform.position = new Vector3(x,y, 0);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
