using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject leftPaw;
    public GameObject rightPaw;

    //public GameObject hoose;

    SpriteRenderer leftRend;
    SpriteRenderer rightRend;

    Vector4 pawColour;

    Animator hooseAnim;
    Animator leftPawAnim;
    Animator rightPawAnim;

    //public bool leftSlap = false;

    // Use this for initialization
    void Start()
    {
        leftRend = leftPaw.GetComponent<SpriteRenderer>();
       // rightRend = rightPaw.GetComponent<SpriteRenderer>();

        pawColour = leftRend.color;

        //hooseAnim = hoose.GetComponent<Animator>();
        leftPawAnim = leftPaw.GetComponent<Animator>();
        rightPawAnim = rightPaw.GetComponent<Animator>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        if (Input.GetKeyDown("left"))
        {
            leftPawAnim.SetBool("Slapping", true);
        }
        else if (Input.GetKeyUp("left"))
        {
            leftPawAnim.SetBool("Slapping", false);
        }

        if (Input.GetKeyDown("right"))
        {
            rightPawAnim.SetBool("Slapping", true);
        }
        else if (Input.GetKeyUp("right"))
        {
            rightPawAnim.SetBool("Slapping", false);
        }

        if (Input.GetKeyDown("left") && Input.GetKeyDown("right"))
        {
            rightPawAnim.SetBool("Slapping", true);
            leftPawAnim.SetBool("Slapping", true);
        }
        else if (Input.GetKeyUp("left") && Input.GetKeyUp("right"))
        {
            rightPawAnim.SetBool("Slapping", false);
            leftPawAnim.SetBool("Slapping", false);
        }
    }
}
