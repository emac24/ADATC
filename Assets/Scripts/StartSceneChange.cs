using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneChange : MonoBehaviour
{
    public GameObject panel;
    public void PlayGame() {
        SceneManager.LoadScene("MainScene");
    }

    public void HowToPlay() {
        panel.SetActive(true);
    }

    public void Close() {
        panel.SetActive(false);
    }

    void Update() {
        if (Input.GetKey("escape")) {
            Application.Quit();
        }
    }

}
