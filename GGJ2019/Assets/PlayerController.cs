using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject leftPaw;
    public GameObject rightPaw;

    public GameObject house;

    SpriteRenderer leftRend;
    SpriteRenderer rightRend;

    Vector4 pawColour;
    
    Animator leftPawAnim;
    Animator rightPawAnim;
    Animator houseAnim;

    int score;

    // Use this for initialization
    void Start()
    {
        leftRend = leftPaw.GetComponent<SpriteRenderer>();
       // rightRend = rightPaw.GetComponent<SpriteRenderer>();

        pawColour = leftRend.color;
        
        leftPawAnim = leftPaw.GetComponent<Animator>();
        rightPawAnim = rightPaw.GetComponent<Animator>();

        houseAnim = house.GetComponent<Animator>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        GameObject target = GameObject.Find("Hit_marker");
        Rob_Beats rb;
        rb = target.GetComponent<Rob_Beats>();
        score = rb.points;

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

        houseAnim.SetInteger("Progress", score);
    }
}
