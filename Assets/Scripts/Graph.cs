using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour {

    public Transform pointPrefab;
    private GetGraphValues graphValues;
    private Transform point;
    float time;
	// Use this for initialization
	void Start () {
        GameObject sphereObject = GameObject.FindWithTag("Ball");
        graphValues = sphereObject.GetComponent<GetGraphValues>();
        time = 0;
        point = Instantiate(pointPrefab);
        point.localPosition = transform.position + new Vector3(time, graphValues.graph_values.y, 0);
	}
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime;
        point = Instantiate(pointPrefab);
        point.localPosition = transform.position + new Vector3(time, graphValues.graph_values.y, 0);

    }
}
