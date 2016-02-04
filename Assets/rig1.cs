using UnityEngine;
using System.Collections;

public class rig1 : MonoBehaviour {
    public int speed = 5;
    public Transform amm;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("h"))
        {
            Transform g = (Transform)Instantiate(amm, transform.position, transform.rotation);
            g.GetComponent<Rigidbody>().AddForce(transform.right * speed);
        }
    }
}
