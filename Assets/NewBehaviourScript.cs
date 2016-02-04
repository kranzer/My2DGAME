using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("right"))
            transform.Translate(new Vector3(0.1f, 0, 0));
        else if (Input.GetKey("left"))
            transform.Translate(new Vector3(-0.1f, 0, 0));
        else if (Input.GetKey("up"))
            transform.Translate(new Vector3(0, 0.1f, 0));
        else if (Input.GetKey("down"))
            transform.Translate(new Vector3(0, -0.1f, 0));
    }
}
