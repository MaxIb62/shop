using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    
    public GameObject CoinSpawn;     
    public Vector2 areaSize = new Vector2(5, 5); 
    public float spawnInterval = 3f;     

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    System.Collections.IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnRandom();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnRandom()
    {
        Vector2 randomPos = new Vector2(
            Random.Range(-areaSize.x / 2f, areaSize.x / 2f),
            Random.Range(-areaSize.y / 2f, areaSize.y / 2f)
        );

        Vector3 spawnPosition = transform.position + new Vector3(randomPos.x, randomPos.y, 0);
        Instantiate(CoinSpawn, spawnPosition, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, new Vector3(areaSize.x, areaSize.y, 0));
    }
}

