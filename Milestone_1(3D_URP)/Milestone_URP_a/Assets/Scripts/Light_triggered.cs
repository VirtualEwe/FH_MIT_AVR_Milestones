using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Light_triggered : MonoBehaviour
{
    public Light Light1;

    // Start is called before the first frame update
    void Start()
    {

        Light1.GetComponent<Light>().enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        Light1.GetComponent<Light>().enabled = true;

    }

    private void OnTriggerExit(Collider other)
    {
        Light1.GetComponent<Light>().enabled = false;   
    }
}
