using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawAxes : MonoBehaviour {

    public Transform pointPrefab;
    private Transform xPoint, yPoint;
    float x, y;
    // Use this for initialization
    void Awake()
    {
        int i = 0;
        x = 0;
        y = 0;
        xPoint = Instantiate(pointPrefab);
        yPoint = Instantiate(pointPrefab);
        xPoint.localPosition = transform.position;
        yPoint.localPosition = transform.position;
        while(i <1000){
            x = i * .1f;
            y = i * .1f;
            xPoint = Instantiate(pointPrefab);
            xPoint.localPosition = transform.position + new Vector3(x, 0, 0);
            yPoint = Instantiate(pointPrefab);
            yPoint.localPosition = transform.position + new Vector3(0, y, 0);
            i++;
        }
    }

    // Update is called once per frame

}
