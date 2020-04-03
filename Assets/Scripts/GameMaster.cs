using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    private GameObject player;
    private AudioSource fxSound;

    public GameObject finishLevelUI;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

	public void gameOver() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update() {

        if (Input.GetKey("r"))
            gameOver();

        if(player.transform.position.y <= -5)
            gameOver();
    }

    public void FinishLevel() {
        fxSound = GetComponent<AudioSource>();
        fxSound.Play();

        finishLevelUI.SetActive(true);

        player.GetComponent<Rigidbody>().useGravity = false;
    }
}
