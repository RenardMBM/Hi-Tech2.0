﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(0, 350, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
