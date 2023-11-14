using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class LeverON_objectrotates : MonoBehaviour
{
    public XRLever mylever;

    public float RotationSpeed;


    void Start()
    {
    }

    void Update()
    {

        float rotationAmount = RotationSpeed*(mylever.value ?1 : 0);

        transform.Rotate(0, rotationAmount * Time.deltaTime, 0);
    }

 
}
