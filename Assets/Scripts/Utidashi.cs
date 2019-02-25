using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utidashi : MonoBehaviour {

	void Start () {
		
	}

  
	
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();
            Vector3 force = new Vector3(0.0f,-150f, 0.0f);
            rb.AddForce(force ,ForceMode.Force);
        }
	}
}
