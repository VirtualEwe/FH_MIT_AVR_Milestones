using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPushLASERoff : MonoBehaviour
{

    public Animator animator;
    public string boolName = "laser_bool";


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => ToggleLaserOff());

    }

    // Update is called once per frame
    //void Update()
    //{
        
   // }


    public void ToggleLaserOff()
    {
        bool isOFF = animator.GetBool(boolName);
        animator.SetBool(boolName, !isOFF);
    }


}
