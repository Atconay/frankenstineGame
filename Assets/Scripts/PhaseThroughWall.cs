using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseThroughWall : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = true;                ;
        }
    }
}
