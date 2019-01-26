using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject leftPaw;
    public GameObject rightPaw;

    SpriteRenderer leftRend;
    SpriteRenderer rightRend;

    Vector4 pawColour;

    // Use this for initialization
    void Start()
    {
        leftRend = leftPaw.GetComponent<SpriteRenderer>();
        rightRend = rightPaw.GetComponent<SpriteRenderer>();

        pawColour = leftRend.color;
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        if (Input.GetKeyDown("left"))
        {
            Debug.Log("Left Key Down");
            leftRend.color = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            rightRend.color = pawColour;
        }
        else if (Input.GetKeyUp("left"))
        {
            leftRend.color = pawColour;
        }


        if (Input.GetKeyDown("right"))
        {
            Debug.Log("Right Key Down");
            rightRend.color = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            leftRend.color = pawColour;
        }
        else if (Input.GetKeyUp("right"))
        {
            rightRend.color = pawColour;
        }

        if (Input.GetKeyDown("left") && Input.GetKeyDown("right"))
        {
            Debug.Log("Both Keys Down");
            leftRend.color = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
            rightRend.color = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
        }
        else if (Input.GetKeyUp("left") && Input.GetKeyUp("right"))
        {
            rightRend.color = pawColour;
            leftRend.color = pawColour;
        }
    }
}
