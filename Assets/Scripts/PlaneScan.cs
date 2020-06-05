using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScan : MonoBehaviour
{
    public Transform plane;
    public Vector3 planeOrigin;
    public float limit = 10;
    public float scanSpeed = 5;
    public bool scanning = false;

    // Start is called before the first frame update
    void Start()
    {
        planeOrigin = plane.position;
        scanning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (scanning)
        {
            plane.position = new Vector3(plane.position.x - Time.deltaTime * scanSpeed, plane.position.y, plane.position.z);

            if (plane.position.x <= planeOrigin.x - limit)
            {
                scanning = false;
                plane.position = planeOrigin;
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            scanning = true;
            plane.position = planeOrigin;
        }
    }
}
