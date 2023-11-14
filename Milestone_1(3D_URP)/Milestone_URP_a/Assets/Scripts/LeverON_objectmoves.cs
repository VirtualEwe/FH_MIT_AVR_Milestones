using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class LeverON_objectmoves : MonoBehaviour
{
    public XRLever mylever;
    //public GameObject MovingSPHERE;

    public float MovingSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float forwardVelocity = MovingSpeed*(mylever.value ?1 : 0);

        Vector3 velocity = new Vector3(0, 0, forwardVelocity);
        transform.position += velocity * Time.deltaTime;
    }

   /* public void GoToLocation1()

    {
        MovingSPHERE.transform.position = new Vector3(0,0,0);

    }

    public void GoToLocation2()
    {
        MovingSPHERE.transform.position = new Vector3(-1, -1, -1);
    }
   */
}
