using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRig : MonoBehaviour {

    [SerializeField]
    private Transform followedObject;

    [SerializeField]
    private Vector3 offset;

    void Start() {
        offset = transform.position - followedObject.position;
    }

    // Update is called once per frame
    void Update () {
        transform.position = followedObject.position + offset;
    }
}
