using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour
{
    public Rigidbody rb;
    public float mass;
    bool isRigged;
    //bool isFallen = false;

    void Update()
    {
        rb = GetComponent<Rigidbody>();
        
        if (LevelGenerator.levelVal % 2 == 0) {
            rb.mass = 1;
            isRigged = false;
        } else {
            rb.mass = 5;
            isRigged = true;
        } 
    }

   void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Ball") {
            ScoreManager.instance.AddPoint();
        }
    }
}
