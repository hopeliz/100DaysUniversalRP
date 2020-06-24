using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBook : MonoBehaviour
{
    public float moveSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles += Vector3.back * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += Vector3.forward * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.eulerAngles += Vector3.left * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.eulerAngles += Vector3.right * Time.deltaTime * moveSpeed;
        }
    }
}
