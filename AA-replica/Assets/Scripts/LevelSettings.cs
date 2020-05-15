using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSettings : MonoBehaviour
{
    public void Restart()
    {
        GameManager.Instance.RestartLevel();
    }
}
