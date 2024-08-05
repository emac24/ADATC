using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectTickets : MonoBehaviour
{

    public static CollectTickets instance;
    public GameObject tcktText;
    public Text tcktAmnt;
    public  static int numOfTickets = 0;


    private void Awake() {
        instance = this;
    }
    
    void Start()
    {
        tcktText.SetActive(false);
        tcktAmnt.text = numOfTickets.ToString();
    }


    private void OnTriggerStay(Collider other) {
        if (other.CompareTag("Player")) {
            tcktText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E)) {
                AddTickets();
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            tcktText.SetActive(false);
        }
    }

    public void AddTickets() {
        numOfTickets += 5;
        numOfTickets = Mathf.Clamp(numOfTickets, 0, 20);
        tcktAmnt.text = numOfTickets.ToString();
    }
}
