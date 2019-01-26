using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rob_Beats : MonoBehaviour {

    public int points;
    bool down;
    public bool hit_L;
    public bool hit_R;
    public bool hit;
    public int type;
    public Text score;
    GameObject cull;
    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {

        GameObject go = GameObject.Find("Hit_marker(1)");
        Rob_good_beat good = go.GetComponent<Rob_good_beat>();
        int good_points = good.points;
        bool good_hit = good.hit;
        bool good_hit_L = good.hit_L;
        bool good_hit_R = good.hit_R;

        points = good_points;

      

        if (Input.GetKeyDown("left") && hit_L == true && good_hit_L == false)
        {
            points = points + 50;
            score.text = ("score: " + points);
            hit_L = false;
            Destroy(cull);
            //points = points + 100;
            Debug.Log(points);
            
        }

         if (Input.GetKeyDown("left") && hit_L == false && good_hit_L == false)
        {
            Debug.Log("NO");
          
            hit_R = false;
            hit = false;
            Destroy(cull);
           
        }

        if (Input.GetKeyDown("right") && hit_R == true && good_hit_R == false)
        {
            points = points + 50;
            score.text = ("score: " + points);
            hit_R = false;
            Destroy(cull);
           
            //points = points + 100;
            Debug.Log(points);
            
        }

        if (Input.GetKeyDown("right") && hit_R == false && good_hit_R == false)
        {
            Debug.Log("NO");
            score.text = ("score: " + points);
            hit_L = false;
            hit = false;
            Destroy(cull);
           

        }

        if (Input.GetKeyDown("left") && Input.GetKeyDown("right") && hit == true && good_hit == false)
        {
            points = points + 100;
            score.text = ("score: " + points);
            hit = false;
            Destroy(cull);
            //points = points + 100;
            Debug.Log(points);
            
        }

        if (Input.GetKeyDown("left") && Input.GetKeyDown("right") && hit == false && good_hit == false)
        {
            Debug.Log("NO");
            points = points + 100;
            score.text = ("score: " + points);
            hit_L = false;
            hit_R = false;
            Destroy(cull);
            //points = points + 100;
            
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
            points = points - 3;
            Destroy(cull);
            score.text = ("score: " + points);
            hit_L = false;
        }
        if (collision.gameObject.tag == "Note_R")
        {
            points = points - 3;
            Destroy(cull);
            score.text = ("score: " + points);
            hit_R = false;
        }
        if (collision.gameObject.tag == "Note")
        {
            points = points - 2;
            Destroy(cull);
            score.text = ("score: " + points);
            hit = false;
        }
    }
}
