using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPrize : MonoBehaviour
{
    int latestScore = 0;
    public static bool played = false;
    public bool collected = false;

   void Start() {
        latestScore = PlayerPrefs.GetInt("recentScore", 0);
   }

    void Update() {
        if (Input.GetMouseButtonDown(0) && played == true) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Debug.Log("This is selected");
            if (Physics.Raycast(ray, out hit)) {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null && bc.CompareTag("TopPrize") && latestScore >= 80 && collected == false) {
                    Destroy(bc.gameObject);
                    collected = true;
                }

                if (bc != null && bc.CompareTag("LowPrize") && latestScore >= 1 && collected == false) {
                    Destroy(bc.gameObject);
                    collected = true;
                }
            }
        }
    }

}
