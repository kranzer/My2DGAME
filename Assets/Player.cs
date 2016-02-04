using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("d"))
            transform.Translate(new Vector3(0.1f, 0, 0));
        else if (Input.GetKey("a"))
            transform.Translate(new Vector3(-0.1f, 0, 0));
        else if (Input.GetKey("w"))
            transform.Translate(new Vector3(0, 0.1f, 0));
        else if (Input.GetKey("s"))
            transform.Translate(new Vector3(0, -0.1f, 0));

       
    }

}
