using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    public float slowMotionScale = 0.5f;
    private void Awake()
    {
        Time.timeScale *= slowMotionScale;
        Time.fixedDeltaTime *= slowMotionScale;
    }
}
