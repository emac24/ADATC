using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueMusic : MonoBehaviour
{
    void Awake() {
        GameObject[] themeMusic = GameObject.FindGameObjectsWithTag("ThemeMusic");
        if (themeMusic.Length > 1) {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
