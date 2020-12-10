﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    SpriteRenderer sr;
    bool active = false;
    GameObject note,gm;
    Color old;
    public bool createMode;
    public GameObject n;
    

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Start()
    {

        gm = GameObject.Find("GameManager");
        old = sr.color;
    }




    private void OnMouseDown()
    {
        if (createMode)
        {
            Instantiate(n, transform.position, Quaternion.identity);
        }

        else
        {
            StartCoroutine(Pressed);
            if (active)
            {
                Destroy(note);
                gm.GetComponent<GameManager>().AddStreak();
                AddScore();
                active = false;
            }
            else if (!active)
                gm.GetComponent<GameManager>().ResetStreak();
        }
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "WinNote")
        {
            gm.GetComponent<GameManager>().Win();
        }

        if (col.gameObject.tag == "Note")
        {
            note = col.gameObject;
            active = true;
        }
        }

    void OnTriggerExit2D(Collider2D col)
    {
        active = false;
        /*gm.GetComponent<GameManager>().ResetStreak();*/
    }

    void AddScore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + gm.GetComponent<GameManager>().GetScore());
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