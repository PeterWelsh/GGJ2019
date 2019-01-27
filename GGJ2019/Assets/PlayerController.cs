using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject leftPaw;
    public GameObject rightPaw;
    public Animator controls;

    public GameObject house;

    SpriteRenderer leftRend;
    SpriteRenderer rightRend;
    
    Animator leftPawAnim;
    Animator rightPawAnim;
    Animator houseAnim;

    int score;
    bool started = false;

    // Use this for initialization
    void Start()
    {
        leftRend = leftPaw.GetComponent<SpriteRenderer>();
       // rightRend = rightPaw.GetComponent<SpriteRenderer>();
        
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
            if(started == false)
            {
                started = true;
                controls.SetTrigger("Started");
            }
            else
            {
                rightPawAnim.SetBool("Slapping", true);
                leftPawAnim.SetBool("Slapping", true);
            }
        }
        else if (Input.GetKeyUp("left") && Input.GetKeyUp("right"))
        {
            rightPawAnim.SetBool("Slapping", false);
            leftPawAnim.SetBool("Slapping", false);
        }

        houseAnim.SetInteger("Progress", score);
    }
}
