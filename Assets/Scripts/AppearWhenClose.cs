using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearWhenClose : MonoBehaviour
{
    public Transform objectTriggeredBy;
    public GameObject appearingObject;
    public float apearRate = 0.1F;
    public float appearCountdown = 1;
    public bool appearing = false;
    public bool disappearing = false;
    public bool visible = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //print(appearingObject.GetComponent<Renderer>().material.GetFloat("Vector1_47645657"));

        gameObject.GetComponent<Renderer>().material.SetFloat("Vector1_47645657", Vector3.Distance(transform.position, objectTriggeredBy.position) / 10 - 3);
        
    }
}
