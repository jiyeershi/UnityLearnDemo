using UnityEngine;
using System.Collections;

public class Done_Mover : MonoBehaviour
{
	public float speed;

	void Start ()
	{
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
	}
}
