using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_ctr : Singleton<Rotation_ctr>
{
    public float speed = 100f;
    public Transform rotator;
    public Transform colorWheel;

    // Update is called once per frame
    void Update()
    {
        rotator.Rotate(0f, 0f, speed * Time.deltaTime);
        colorWheel.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
