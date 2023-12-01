using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGeneration : MonoBehaviour
{
    public GameObject thunderCloudPrefab;
    public GameObject normalCloudPrefab;
    public float spawnInterval = 0.005f; // Time between spawns
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        float xSpawningPoint = Random.Range(-2.5f, 2.5f);
        Debug.Log("Spawning point is: " + xSpawningPoint);
        Vector3 spawnPoint = new Vector3(xSpawningPoint, 4, 0);
        GameObject selectedPrefab = Random.value < 0.5f ? thunderCloudPrefab : normalCloudPrefab;
        Instantiate(selectedPrefab, spawnPoint, Quaternion.identity);
    }
}
