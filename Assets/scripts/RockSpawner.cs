using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    // ENCAPSULATION
    private float spawnInterval;
    public GameObject RockPrefab;
    MoveMethods rock;
    private GameObject player;
    private Vector3 directionToPlayer;

    private void SpawnRock()
    {
        Vector3 spawnPos = new Vector3((Random.value - 0.5f) * 500, (Random.value - 0.5f) * 500, 0).normalized * 600f + transform.position;


        rock = Instantiate(RockPrefab, spawnPos, RockPrefab.transform.rotation, transform).GetComponent<MoveMethods>();
        directionToPlayer = (player.transform.position - rock.transform.position).normalized;

    }

    private void Start()
    {
        player = GameObject.Find("Player");
        spawnInterval = Mathf.Pow(1.1f, Time.timeSinceLevelLoad);
    }

    private void Update()
    {
        spawnInterval -= Time.deltaTime;

        if (spawnInterval <= 0)
        {
            if (rock != null)
            {
                rock.Move(directionToPlayer);
            }

            SpawnRock();
            spawnInterval = Mathf.Pow(1.1f, -0.5f * Time.timeSinceLevelLoad) + 1;
        }
    }
}
