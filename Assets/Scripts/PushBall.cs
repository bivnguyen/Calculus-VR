using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBall : MonoBehaviour {
    public Vector3 ForceVector;
    private Rigidbody rb;
    public Vector3 startPosition;
    public Vector3 playerPosition;


	// Use this for initialization
	void Start () {
        //GameObject player = ga
        startPosition = gameObject.transform.position;
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeAll;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.AddForce(ForceVector, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            transform.position = startPosition;

        }
        
	}
}
