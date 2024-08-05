using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public int score = 0;

    private void Awake() {
        instance = this;
    }
    
    void Start() {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddPoint() {
        score += 10;
        scoreText.text = "Score: " + score.ToString();
        PlayerPrefs.SetInt("recentScore", score);
    }

}
