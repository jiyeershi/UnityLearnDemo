using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("BallController start");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("222222");
	}
}
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// 
// public class NewBehaviourScript : MonoBehaviour
// {
// 
//     private Rigidbody rb;
//     public float thrust = 24.0f;
//     // Use this for initialization
//     void Start()
//     {
//         rb = GetComponent<Rigidbody>();
//     }
// 
//     // Update is called once per frame
//     void Update()
//     {
//         if (transform.position.y < -10)
//         {
//             Destroy(gameObject);
//             Application.Quit();
//         }
//     }
// 
//     void OnCollisionEnter(Collision collision)
//     {
//         rb.AddForce(new Vector3(Random.Range(0.2f, -0.2f), 1.0f, 0) * thrust);
//     }
// }
