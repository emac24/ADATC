using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public static int levelVal;

    void Start()
    {
        levelVal = Random.Range(1, 11);
        Debug.Log(levelVal);
    }

}
