using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour {

    GameObject master;

    void Start() {
        master = GameObject.FindGameObjectWithTag("GameMaster");
    }
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player")
            master.GetComponent<GameMaster>().gameOver();
    }
}
