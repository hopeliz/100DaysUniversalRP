using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedBehavior : MonoBehaviour
{
    public PlayerMotor2 PlayerMotor2;
    public Material defaultMaterial;
    public Material selectedMaterial;
    public bool selected = false;

    // Start is called before the first frame update
    void Start()
    {
        defaultMaterial = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMotor2.selectedObject != null)
        {
            if (PlayerMotor2.selectedObject.name == transform.name)
            {
                selected = true;
            }
            else
            {
                selected = false;
            }

            if (selected)
            {
                selectedMaterial.SetColor("Main_Color", defaultMaterial.color);
                GetComponent<MeshRenderer>().material = selectedMaterial;
            }
            else
            {
                GetComponent<MeshRenderer>().material = defaultMaterial;
            }
        }
        
    }
}
