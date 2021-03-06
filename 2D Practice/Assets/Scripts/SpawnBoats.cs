using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoats : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pirateBoat;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public static float timeBetweenSpawn = 8;
    private float spawnTime;
    public float ogSpawnTime;

    // Update is called once per frame
    void Update()
    {
        if ((Time.time > spawnTime) && (Time.time > ogSpawnTime))
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(pirateBoat, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
