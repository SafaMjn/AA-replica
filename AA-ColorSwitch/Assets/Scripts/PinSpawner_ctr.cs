using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner_ctr : Singleton<PinSpawner_ctr>
{
    public GameObject pinPrefab;
    public Transform spawnPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnPin();
        }
    }

     void SpawnPin()
    {
        Instantiate(pinPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
