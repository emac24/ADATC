using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    private Vector3 spawnPos;
    public GameObject spawnObj;
    private float spawnSpeed = 1.0f;
    int spawned = 0;

    public static Spawner Instance;

    private void Awake() {
        Instance = this;
    }
    void Start()
    {
        spawnPos = transform.position;
    }

    void SpawnNewObject() {
        Instantiate(spawnObj, new Vector3(870.6f, 5.9f, 1.89f), Quaternion.identity);
    }

    public void NewSpawnRequest(){
        Invoke("SpawnNewObject", spawnSpeed);
        spawned += 1;
    }

    void Update() {
        if (spawned == 4) {
            SceneManager.LoadScene("MainScene");
        }
    }

    
}
