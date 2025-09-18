using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball1 : MonoBehaviour
{
    [SerializeField] Vector3 Velocity = new Vector3 (1, 1, 0);
    Vector2 minScreen, maxScreen;
    [SerializeField] Vector3 acceleration = new Vector3 (0, -1, 0);


    private void Start()
    {
       minScreen = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxScreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        print(minScreen);
        print(maxScreen);   
    }
    void Update()
    {
        Velocity += acceleration * Time.deltaTime;
        transform.position += Velocity * Time.deltaTime;

        Vector3 pos = transform.position;

        if (pos.y > maxScreen.y)
        {
            Velocity.y = -Mathf.Abs(Velocity.y);
        }
        if (pos.x > maxScreen.x)
        {
            Velocity.x = -Mathf.Abs(Velocity.x);
        }

        if (pos.y < minScreen.y) 
        {
            Velocity.y = Mathf.Abs(Velocity.y);
        }
        if(pos.x < minScreen.x)
        {
            Velocity.x = Mathf.Abs(Velocity.x);
        }

    }
}
