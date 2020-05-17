using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner_ctr : Singleton<PinSpawner_ctr>
{
    public GameObject pinPrefab;
    public SpriteRenderer spawnSprite;
    public Transform spawnPoint;

    public Color[] colors;
    int random;
    void Start()
    {
        SelectRandomColor();
    }

    private void SelectRandomColor()
    {
        random = UnityEngine.Random.Range(0, colors.Length);
        Color color = colors[random];
        color.a = 0.75f;
        spawnSprite.color = color;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnPin();
            SelectRandomColor();
        }
    }

     void SpawnPin()
    {
       GameObject newPin = Instantiate(pinPrefab, spawnPoint.position, spawnPoint.rotation);
       newPin.GetComponent<Pin_mb>().color = colors[random];
    }
}
