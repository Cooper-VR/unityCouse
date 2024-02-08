using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    private float spawnInterval;
    public GameObject RockPrefab;

    private void SpawnRock()
    {
        Vector3 spawnPos = new Vector3((Random.value - 0.5f) * 500, (Random.value - 0.5f) * 500, 0).normalized * 600f + transform.position;

        Instantiate(RockPrefab, spawnPos, RockPrefab.transform.rotation, transform);
    }

    private void Start()
    {
        spawnInterval = Mathf.Pow(1.1f, Time.timeSinceLevelLoad);
    }

    private void Update()
    {
        spawnInterval -= Time.deltaTime;

        if (spawnInterval <= 0)
        {
            SpawnRock();
            spawnInterval = Mathf.Pow(1.1f, -0.5f * Time.timeSinceLevelLoad) + 1;
        }
    }
}
