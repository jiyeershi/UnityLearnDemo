using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {

    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        print("MoveBall start");
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log("5555");
	}

    void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(new Vector3(Random.Range(-0.2f, 0.2f), 1.0f, 0.0f) * 20);
    }
}
