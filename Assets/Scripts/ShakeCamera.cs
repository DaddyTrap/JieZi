﻿using UnityEngine;
using System.Collections;

public class ShakeCamera : MonoBehaviour
{
    private Vector3 deltaPos = Vector3.zero;
    
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        transform.localPosition -= deltaPos;
        deltaPos = Random.insideUnitSphere / 3.0f;
        transform.localPosition += deltaPos;
    }
}