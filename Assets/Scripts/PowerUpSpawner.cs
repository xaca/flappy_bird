using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    
    public GameObject powerUpPrefab; 
    public float spawnRate = 15f; 
    public float yOffset = 2f;

    private float timer = 0;

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPowerUp();
            timer = 0;
        }
    }


    void SpawnPowerUp()
    {
        float lowerPoint = transform.position.y - yOffset;
        float upperPoint = transform.position.y + yOffset;

        Instantiate(powerUpPrefab, new Vector3(transform.position.x, Random.Range(lowerPoint, upperPoint), 0), transform.rotation);
    }
}
