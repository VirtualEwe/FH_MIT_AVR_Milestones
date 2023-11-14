using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class LeverON_lightON : MonoBehaviour
{
    public XRLever mylever;

    public Light mylight;


    void Start()
    {
    }

    void Update()
    {

        if(mylever.value)
        {
            mylight.enabled = true;
        }
        else
        {
            mylight.enabled = false;
        }

    }

 
}
