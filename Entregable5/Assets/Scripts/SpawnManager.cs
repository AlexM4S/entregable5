using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(0, 0, 30);
    public float spawnRange = 10f;
    private float randomY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0.5f, 5f);
    }

    public void SpawnObstacle()
    {
        randomY = Random.Range(spawnRange, -spawnRange -1);
        spawnPos = new Vector3(0, randomY ,spawnPos.z +50);
        
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
