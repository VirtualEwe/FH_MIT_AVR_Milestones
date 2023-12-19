using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Script_1_moving_steps : MonoBehaviour
{
    public Animator Steps;
    public Transform Player;
    public Transform Stairs;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Player.position, Stairs.position);

        if (distance <= 3)
        {
            Steps.SetBool("Near", true);
        }
        else
        {
            Steps.SetBool("Near", false);
        }

    }
}
