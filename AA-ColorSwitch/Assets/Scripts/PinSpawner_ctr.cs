using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner_ctr : Singleton<PinSpawner_ctr>
{
    public GameObject pinPrefab;
    public SpriteRenderer spawnSprite;
    public Transform spawnPoint;

    public Color32[] colors;
    int random;
    void Start()
    {
        SelectRandomColor();
    }

    private void SelectRandomColor()
    {
        random = UnityEngine.Random.Range(0, colors.Length);
        Color32 color = colors[random];
        color.a = 190;
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
