using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassValues : MonoBehaviour {
    public Terrain terrain;
    private Transform transformValues;
	// Use this for initialization
	void Start () {
        ;
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = terrain.transform.rotation;

    }
}
