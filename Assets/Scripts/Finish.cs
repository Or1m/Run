using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

    GameObject master;

    void Start() {
        master = GameObject.FindGameObjectWithTag("GameMaster");
    }

    void OnTriggerEnter() {
            master.GetComponent<GameMaster>().FinishLevel();
    }
}
