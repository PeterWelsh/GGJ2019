using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rob_Miss_check : MonoBehaviour {

    int ok_points;
    Rob_Beats ok;
    public int points;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject go = GameObject.Find("Hit_marker");
        ok = go.GetComponent<Rob_Beats>();
        ok_points = ok.points;
      
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Note_L")
        {
            ok.points = ok_points - 3;
            Destroy(collision);
        }
        if (collision.gameObject.tag == "Note_R")
        {
            ok.points = ok_points - 3;
            Destroy(collision);
        }
        if (collision.gameObject.tag == "Note")
        {
            ok.points = ok_points - 2;
            Destroy(collision);
        }
    }
}
