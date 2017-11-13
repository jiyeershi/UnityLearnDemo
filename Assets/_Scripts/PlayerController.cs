using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float minX, maxX, minZ, maxZ;
}

public class PlayerController : MonoBehaviour {

    public float speed = 5.0f;
    public float tilt = 4.0f;
    public float fireRate = 0.5f;
    public GameObject shot;
    public Transform shotSpawn;
    public float nextFire = 0.0f;
    public Boundary boundary;
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
	}

    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
//         Debug.Log(moveH);
//         Debug.Log(moveV);
        Vector3 movement = new Vector3(moveH, 0.0f, moveV);
        rb.velocity = movement * speed;
//         rb.position = new Vector3(Mathf.Clamp(rb.position.x, boundary.minX, boundary.maxX), 0.0f,
//             Mathf.Clamp(rb.position.z, boundary.minZ, boundary.maxZ));
        //Debug.Log(rb.velocity);
        rb.rotation = Quaternion.Euler(0.0f, 0.0f,(rb.velocity * -4.0f).x) ;
        //Debug.Log(rb.rotation);
    }
}
