using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rob_good_beat : MonoBehaviour {

    public int points;
    bool down;
    public bool hit_L;
    public bool hit_R;
    public bool hit;
    public int type;
    public Text score;
    int ok_points;
    Rob_Beats ok;
    GameObject cull;

    // Use this for initialization
    void Start()
    {
        
       

    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("Hit_marker");
        ok = go.GetComponent<Rob_Beats>();
        ok_points = ok.points;
        points = ok.points;

        if (Input.GetKeyDown("left") && hit_L == true)
        {
            points = points + 50;
            score.text = ("score: " + points);
            Destroy(cull);
            //points = points + 100;
            Debug.Log(points);
            hit_L = false;
        }

        else if(Input.GetKeyDown("left") && hit_L == false)
        {
            Destroy(cull);
            hit_R = false;
            hit = false;
        }

        if (Input.GetKeyDown("right") && hit_R == true)
        {
            points = points + 50;
            score.text = ("score: " + points);
            Destroy(cull);
            //points = points + 100;
            Debug.Log(points);
            hit_R = false;
        }

        else if (Input.GetKeyDown("right") && hit_R == false)
        {
            Destroy(cull);
            hit_L = false;
            hit = false;
        }


        if (Input.GetKeyDown("left") && Input.GetKeyDown("right") && hit == true)
        {
            points = points + 100;
            score.text = ("score: " + points);
            Destroy(cull);
            //points = points + 100;
            Debug.Log(points);
            hit = false;
        }

        if (Input.GetKeyDown("left") && Input.GetKeyDown("right") && hit == false)
        {
 
            Destroy(cull);
            hit_L = false;
            hit_R = false;
        }


    }

    private void OnTriggerEnter(Collider collision)
    {

       
        if (collision.gameObject.tag == "Note_L")
        {
            hit_L = true;
            Debug.Log(points);
            cull = collision.gameObject;
        }
        if (collision.gameObject.tag == "Note_R")
        {
            hit_R = true;
            Debug.Log(points);
            cull = collision.gameObject;
        }
        if (collision.gameObject.tag == "Note")
        {
            hit = true;
            Debug.Log(points);
            cull = collision.gameObject;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Note_L")
        {
            hit_L = false;
          
        }
        if (collision.gameObject.tag == "Note_R")
        {
            hit_R = false;
            
        }
        if (collision.gameObject.tag == "Note")
        {
            hit = false;
            
        }
    }
}
