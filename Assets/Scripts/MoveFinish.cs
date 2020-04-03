using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFinish : MonoBehaviour {

    public float delta = 15.0f;  // Amount to move left and right from the start point
    public float speed = 1.0f;
    private Vector3 startPos;

    // Use this for initialization
    void Start () {
        startPos = transform.position;
    }

    void Update() {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
