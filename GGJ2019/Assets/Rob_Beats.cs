using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rob_Beats : MonoBehaviour {

    public int points;
    bool down;
    bool hit;
    public int type;
    
   
    // Use this for initialization
    void Start ()
    {
       
    }
	
	// Update is called once per frame
	void Update ()
    {


        if (Input.GetKeyDown("f") && type == 1 && hit == true )
        {
            points = points + 100;
            Debug.Log(points);
        }

        if (Input.GetKeyDown("f") && type == 0 && hit == true)
        {
            points = points + 50;
            Debug.Log(points);
        }

       


    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(points);
        
        if (collision.gameObject.tag == "Note")
        {
            hit = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Note")
        {
            hit = false;
        }
    }
}
