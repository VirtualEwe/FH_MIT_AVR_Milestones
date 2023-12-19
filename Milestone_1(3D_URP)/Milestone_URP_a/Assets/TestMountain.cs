using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TestMountain : MonoBehaviour
{
    
    public Animator MountainM;
    private XRBaseInteractable LeverM;
    public string boolNamee = "BolM";

    // Start is called before the first frame update
    void Start()
    {

        MountainM = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnLeverPull()
    {
        MountainM.SetBool("BolM", true);

    }
}
