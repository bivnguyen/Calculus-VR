using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGraphValues : MonoBehaviour {

    // Use this for initialization
    public Rigidbody rb;
    float delta_time;
    public Vector3 graph_values;
    private Vector3 velocity_vector;
    private float curr_velocity;
    private float prev_velocity;
    float accel;
    void Start () {
        rb = GetComponent<Rigidbody>();
        curr_velocity = 0;
        prev_velocity = 0;
	}
	
	// Update is called once per frame
	void Update () {
        delta_time = Time.deltaTime;
        prev_velocity = curr_velocity;
        velocity_vector = rb.velocity;
        curr_velocity = velocity_vector.magnitude;
        accel = (curr_velocity - prev_velocity) / delta_time;
        graph_values.x = 0;
        graph_values.y = curr_velocity;
        graph_values.z = accel;
        Debug.Log(graph_values);
	}
}
