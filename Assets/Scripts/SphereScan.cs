using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScan : MonoBehaviour
{
    public Transform sphere;
    public float minSize = 0;
    public float maxSize = 10;
    public float expandSpeed = 2;
    public float expandCountdown = 1;
    public bool expanding = false;

    void Start()
    {
        sphere.localScale = new Vector3(0, 0, 0);
        expanding = false;
    }

    void Update()
    {
        if (expanding)
        {
            sphere.localScale = new Vector3(sphere.localScale.x + Time.deltaTime * expandSpeed, sphere.localScale.y + Time.deltaTime * expandSpeed, sphere.localScale.z + Time.deltaTime * expandSpeed);
            
            if (sphere.localScale.x >= maxSize)
            {
                expanding = false;
                sphere.localScale = new Vector3(minSize, minSize, minSize);
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            expanding = true;
            sphere.localScale = new Vector3(minSize, minSize, minSize);
        }
    }
}
