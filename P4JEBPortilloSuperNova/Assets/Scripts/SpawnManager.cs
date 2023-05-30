using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void SpawnRandomEnemy()
    {

        // Randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        Vector3 spawnPosHorizontalNegative = new Vector3(-spawnPosZ, 0, Random.Range(0, spawnRangeX));
        Instantiate(enemyPrefabs[enemyIndex], spawnPosHorizontalNegative, Quaternion.Euler(0, 90, 0));
        Vector3 spawnPosHorizontalPositive = new Vector3(spawnPosZ, 0, Random.Range(0, spawnRangeX));
        Instantiate(enemyPrefabs[enemyIndex], spawnPosHorizontalPositive, Quaternion.Euler(0, 90, 0));

    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
