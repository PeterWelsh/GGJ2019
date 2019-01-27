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
    int combo;
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

        if (Input.GetKeyDown("left") && Input.GetKeyDown("right") && hit == true && good_hit == false)
        {
            points = points + 100 + (2*combo);
            combo = combo + 1;
            score.text = ("score: " + points + " Combo: " + combo);
            hit = false;
            Destroy(cull);
            Debug.Log(combo);

        }

      else  if (Input.GetKeyDown("left") && Input.GetKeyDown("right") && hit == false)
        {
            combo = 0;
            Debug.Log("NO");

            hit_L = false;
            hit_R = false;
            Destroy(cull);


        }

       else  if (Input.GetKeyDown("left")  && hit_L == true && good_hit_L == false)
        {
            points = points + 50 + (2 * combo); 
            combo = combo + 1;
            score.text = ("score: " + points + " Combo: " + combo);
            hit_L = false;
            Destroy(cull);
            
            Debug.Log(combo);
            
        }

       else  if (Input.GetKeyDown("left") && hit_L == false)
        {
            combo = 0;
            Debug.Log("cat");
          
            hit_R = false;
            
            Destroy(cull);
           
        }

       else  if (Input.GetKeyDown("right")  && hit_R == true && good_hit_R == false)
        {
            points = points + 50 + (2 * combo); 
            combo = combo + 1;
            score.text = ("score: " + points + " Combo: " + combo);
            hit_R = false;
            Destroy(cull);
           
            
            Debug.Log(combo);
            
        }

       else if (Input.GetKeyDown("right") && hit_R == false)
        {
            combo = 0;
            Debug.Log("dog");
            score.text = ("score: " + points + " Combo: " + combo);
            hit_L = false;
           
            Destroy(cull);
           

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
            combo = 0;
            points = points - 3;
            Destroy(cull);
            score.text = ("score: " + points + " Combo: " + combo);
            hit_L = false;
        }
        if (collision.gameObject.tag == "Note_R")
        {
            combo = 0;
            points = points - 3;
            Destroy(cull);
            score.text = ("score: " + points + " Combo: " + combo);
            hit_R = false;
        }
        if (collision.gameObject.tag == "Note")
        {
            combo = 0;
            points = points - 2;
            Destroy(cull);
            score.text = ("score: " + points + " Combo: " + combo);
            hit = false;
        }
    }
}
