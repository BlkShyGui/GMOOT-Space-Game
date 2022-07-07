using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnManager : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnRangeX = 1.9f;
    public int asteroidCount;

    // Will use for background clouds and other images
    // Start is called before the first frame update
    void Start()
    {
        SpawnAsteroidWave(3);
    }
    

    void SpawnAsteroidWave(int asteroidsToSpawn)
    {
        for (int i = 0; i < asteroidsToSpawn; i++)
        {
            Instantiate(asteroidPrefab, GenerateSpawnPosition(), asteroidPrefab.transform.rotation);
        }
    }

    private Vector2 GenerateSpawnPosition() //location
    {
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        float spawnPosY = Random.Range(3f, 4f);
        Vector2 randomPos = new Vector2(spawnPosX, spawnPosY);

        return randomPos;
    }
    // Update is called once per frame
    void Update()
    {
        asteroidCount = FindObjectsOfType<Asteroid>().Length;

        if (asteroidCount == 1)
        {
            SpawnAsteroidWave(3);
        }
    }
}

