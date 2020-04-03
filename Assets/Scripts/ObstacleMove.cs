using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObstacleMove : MonoBehaviour {

    float minValue = -4f; // or whatever you want the max value to be
    float maxValue = 4f; // or whatever you want the min value to be

    float delta = 1.5f;

    Vector3 pos, add;

    void Start () {
        pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        add = new Vector3(delta * Time.deltaTime * 3, 0, 0);
        //add = new Vector3(1, 0, 0);
    }

    void Update() {
        if (pos.x >= maxValue) {
            pos.x = maxValue;
            add *= -1;
        }
           
        if (pos.x <= minValue)
            add *= -1;

        pos += add;
        transform.position = pos;
    }

   
}