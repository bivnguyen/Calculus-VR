using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GetGraphValues : MonoBehaviour {

    // Use this for initialization
    public Rigidbody rb;
    public float arclength;
    float delta_time;
    public Vector3 graph_values;
    public Vector3 velocity_vector;
    private float curr_velocity;
    private float prev_velocity;
    private float accel;
    private float oldX;
    private float oldY;
    private float oldZ;
    private float newX;
    private float newY;
    private float newZ;
    private float deltaX;
    private float deltaY;
    private float deltaZ;
    public float Xvelocity;
    public float Yvelocity;
    public float Zvelocity;


    void Start () {
        rb = GetComponent<Rigidbody>();
        curr_velocity = 0;
        prev_velocity = 0;
        velocity_vector = Vector3.zero;
        newX = transform.position.x;
        newY = transform.position.y;
        newZ = transform.position.z;
        arclength = 0;
    }
	
	// Update is called once per frame
	void Update () {

    }
    private void FixedUpdate()
    {
        oldX = newX;
        oldY = newY;
        oldZ = newZ;

        newX = transform.position.x;
        newY = transform.position.y;
        newZ = transform.position.z;

        deltaX = newX - oldX;
        deltaY = newY - oldY;
        deltaZ = newZ - oldZ;

        arclength = Mathf.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ) + arclength;

        delta_time = Time.fixedDeltaTime;

        velocity_vector.x = deltaX / delta_time;
        velocity_vector.y = deltaY / delta_time;
        velocity_vector.z = deltaZ / delta_time;


        //Xvelocity = rb.velocity.x;
        //Yvelocity = rb.velocity.y;

        //Debug.Log(arclength);
        Debug.Log("X Velocity");
        Debug.Log(velocity_vector.x);
        Debug.Log("Y Velocity");
        Debug.Log(velocity_vector.y);
    }

}
