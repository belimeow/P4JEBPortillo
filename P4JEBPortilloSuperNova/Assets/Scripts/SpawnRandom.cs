using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    public GameObject treePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randomRange = Random.Range(-10.0f, 10.0f);
        Vector3 randomPosition = new Vector3(randomRange, 0, 0);

        var Tree = Instantiate(treePrefab, randomPosition, Quaternion.identity);
    }
}
