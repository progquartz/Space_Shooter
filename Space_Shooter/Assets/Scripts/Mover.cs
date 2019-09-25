﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float speed;
    private void Start()
    { 
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * speed;
    }
}
