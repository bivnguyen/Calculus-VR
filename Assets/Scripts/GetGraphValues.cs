using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GetGraphValues : MonoBehaviour {

    // Use this for initialization
    public Rigidbody rb;
    public float arclength;
    float delta_time;
    public Vector3 graph_values;
    private Vector3 velocity_vector;
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


    void Start () {
        rb = GetComponent<Rigidbody>();
        curr_velocity = 0;
        prev_velocity = 0;
        newX = transform.position.x;
        newY = transform.position.y;
        newZ = transform.position.z;
        arclength = 0;
    }
	
	// Update is called once per frame
	void Update () {
        oldX = newX;
        oldY = newY;
        oldZ = newZ;

        newX = transform.position.x;
        newY = transform.position.y;
        newZ = transform.position.z;

        deltaX = Mathf.Abs(newX - oldX);
        deltaY = Mathf.Abs(newY - oldY);
        deltaZ = Mathf.Abs(newZ - oldZ);

        arclength = Mathf.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ) + arclength;

        delta_time = Time.deltaTime;
        prev_velocity = curr_velocity;
        velocity_vector = rb.velocity;
        curr_velocity = velocity_vector.magnitude;
        accel = (curr_velocity - prev_velocity) / delta_time;
        graph_values.x = 0;
        graph_values.y = curr_velocity;
        graph_values.z = accel;

        Xvelocity = rb.velocity.x;
        Yvelocity = rb.velocity.y;

        Debug.Log(graph_values);
        Debug.Log(arclength);
        Debug.Log(Xvelocity);
        Debug.Log(Yvelocity);
	}
   
}
