﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public List<GameObject> colliding = new List<GameObject>();
    public Vector2 up;
    public AudioSource BounceSound;
    void Start()
    {
        countDown.TimesUp += bounceObject;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        colliding.Add(collision.gameObject);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
       colliding.Remove(collision.gameObject);
    }
    void bounceObject()
    {
            foreach (GameObject a in colliding)
            {
            
                if (a != null)
                {
                a.GetComponent<Rigidbody2D>().AddForce(up);
                BounceSound.Play();
                }
            
                
            }
    }
}
