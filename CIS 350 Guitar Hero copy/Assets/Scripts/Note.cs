﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    bool called = false;
  

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("Start") == 1&&!called){
            rb.velocity = new Vector2(0, -speed);
            called = true;
        } 
    }
}
