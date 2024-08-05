using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneChangeOnKeyPress : MonoBehaviour
{
    [SerializeField] private string level;
    [SerializeField] private GameObject uiElement;
    public GameObject warningTxt;
    private void OnTriggerStay(Collider other) {
        if (other.CompareTag("Player")) {
            uiElement.SetActive(true);
            if (CollectTickets.numOfTickets == 0) {
                warningTxt.SetActive(true);
                uiElement.SetActive(false);
            } else {
                if (Input.GetKeyDown(KeyCode.E)) {
                    SceneManager.LoadScene(level);
                    CollectTickets.numOfTickets -= 1;
                    CollectPrize.played = true;
                }
            }
            
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            uiElement.SetActive(false);
            warningTxt.SetActive(false);
        }
    }

    void Start() {
        warningTxt.SetActive(false);
    }
}
