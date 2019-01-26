using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject leftPaw;
    public GameObject rightPaw;

    // Use this for initialization
    void Start()
    {

    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");
        //Debug.Log(moveHorizontal);

        //If left pressed
        if (moveHorizontal < 0.0f)
        {
            Debug.Log("Left");
        }
        // If right pressed
        else if (moveHorizontal > 0.0f)
        {
            Debug.Log("Right");
        }
        else if(moveHorizontal == 0.0f)
        {
            Debug.Log("Neutral");
        }
    }
}
