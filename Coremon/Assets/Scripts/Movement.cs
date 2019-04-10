﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float move = 0.1f;
    

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + move, transform.position.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - move, transform.position.y);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + move);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - move);
        }
    }
}