using UnityEngine;
using System.Collections;


public class rig : MonoBehaviour {
    public int speed = 5000;
    public Transform amm;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("g"))
        {
            Transform g = (Transform)Instantiate(amm, transform.position, transform.rotation);
            g.GetComponent<Rigidbody>().AddForce(transform.localPosition*speed);
            WaitForSeconds wait = new WaitForSeconds(1f);
        }
    }
}
