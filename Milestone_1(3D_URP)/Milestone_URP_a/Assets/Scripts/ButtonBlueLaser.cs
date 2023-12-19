using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonBlueLaser : MonoBehaviour
{

    public Animator animator;
    public string boolName = "bTurningOff";


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => ToggleBlueLaserOff());

    }

    // Update is called once per frame
    //void Update()
    //{
        
   // }


    public void ToggleBlueLaserOff()
    {
        bool isOFF = animator.GetBool(boolName);
        animator.SetBool(boolName, !isOFF);
    }


}
