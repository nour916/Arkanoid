﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket: MonoBehaviour
{
    //players movement and speed

    public float speed = 150;

    public  void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
