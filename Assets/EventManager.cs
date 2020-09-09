using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public  event Action OnClick = delegate { };

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //OnClick();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Here");
            OnClick();
        }
    }
}
