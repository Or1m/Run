using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    [SerializeField]
    private Transform distance;

    [SerializeField]
    private Text score;

    private float startPos;

    void Start() {
        startPos = distance.position.z;
    }

    // Update is called once per frame
    void Update () {
        score.text = (distance.position.z - startPos).ToString("0");
	}
}
