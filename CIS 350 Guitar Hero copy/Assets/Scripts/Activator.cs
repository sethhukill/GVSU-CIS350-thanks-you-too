﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    SpriteRenderer sr;
    bool active = false;
    GameObject note;
    Color old;
    


    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        old = sr.color;
    }


    private void Update()
    {
        
    }

    private void OnMouseDown()
    {
        StartCoroutine(Pressed);
        if (active)
            Destroy(note);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;
        if (col.gameObject.tag == "Note")
            note = col.gameObject;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        active = false;
    }

    IEnumerator Pressed
    {
        get
        {
            sr.color = new Color(0, 0, 0);
            yield return new WaitForSeconds(0.05f);
            sr.color = old;
        }
    }
}