﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRotation : MonoBehaviour {
    private Vector3 difference;
    private float rotZ;
    public int rotationOffset = 0;

    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        // subtracting the position of the player from the mouse position
        difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();         // normalizing the vector. Meaning that the sum of the vector (x + y + z) will equal to 1.

        rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;   // find the angle in degrees
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + rotationOffset);
    }
}