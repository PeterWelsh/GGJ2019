using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rob_Move : MonoBehaviour {
    float speed = 3.0f;
   public int type;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
	}

  
}
