using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
            clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * speed);
        }
    }
}
