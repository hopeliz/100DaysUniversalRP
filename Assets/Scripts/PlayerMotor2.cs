using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor2 : MonoBehaviour
{
    public Transform player;
    public Transform camHolder;
    public GameObject selectedObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Physics.Raycast(camHolder.position, camHolder.TransformDirection(Vector3.forward) * 10000, out RaycastHit hit, Mathf.Infinity))
        {
            print(hit.transform.name);
            Debug.DrawRay(camHolder.position, camHolder.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            if (hit.transform.tag == "Selectable Object")
            {
                selectedObject = hit.transform.gameObject;
            }
            else
            {
                selectedObject = null;
            }
        }
    }
}
