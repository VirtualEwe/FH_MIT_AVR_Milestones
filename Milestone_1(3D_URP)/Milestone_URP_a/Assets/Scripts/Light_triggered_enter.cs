using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Light_triggered_enter : MonoBehaviour
{
    public Light Light_enter;

    // Start is called before the first frame update
    void Start()
    {

        Light_enter.GetComponent<Light>().enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        Light_enter.GetComponent<Light>().enabled = true;

    }

    private void OnTriggerExit(Collider other)
    {
        Light_enter.GetComponent<Light>().enabled = false;   
    }
}
