using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    bool start = false;
    bool quit = false;

    public GameObject leftPaw;
    public GameObject rightPaw;

    Animator leftPawAnim;
    Animator rightPawAnim;

    // Use this for initialization
    void Start () {
        leftPawAnim = leftPaw.GetComponent<Animator>();
        rightPawAnim = rightPaw.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("left"))
        {
            leftPawAnim.SetBool("Slapping", true);
            Debug.Log("Start");
            start = true;
        }
        else if (Input.GetKeyUp("left"))
        {
            leftPawAnim.SetBool("Slapping", false);
        }
        else if(Input.GetKeyDown("right"))
        {
            rightPawAnim.SetBool("Slapping", true);
            Debug.Log("Quit");
            quit = true;
        }
        else if (Input.GetKeyUp("right"))
        {
            rightPawAnim.SetBool("Slapping", false);
        }

        if (start == true)
        {
            StartCoroutine("Wait");
        }

        if(quit == false)
        {
            //Application.Quit();
        }
	}

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SampleScene");
    }
}
