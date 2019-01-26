﻿using System.Collections;
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
            points = points + 100;
            score.text = ("score: " + points);
            Destroy(cull);
            //points = points + 100;
            Debug.Log(points);
            hit_L = false;
        }

        if (Input.GetKeyDown("right") && hit_R == true && good_hit_R == false)
        {
            points = points + 100;
            score.text = ("score: " + points);
            Destroy(cull);
            //points = points + 100;
            Debug.Log(points);
            hit_R = false;
        }

        if (Input.GetKeyDown("left") && Input.GetKeyDown("right") && hit == true && good_hit == false)
        {
            points = points + 200;
            score.text = ("score: " + points);
            Destroy(cull);
            //points = points + 100;
            Debug.Log(points);
            hit = false;
        }


    }

    private void OnTriggerEnter(Collider collision)
    {

        cull = collision.gameObject;
        if (collision.gameObject.tag == "Note_L")
        {
            hit_L = true;
            Debug.Log(points);
        }
        if (collision.gameObject.tag == "Note_R")
        {
            hit_R = true;
            Debug.Log(points);
        }
        if (collision.gameObject.tag == "Note")
        {
            hit = true;
            Debug.Log(points);
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
