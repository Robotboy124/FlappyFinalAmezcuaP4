using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        //give movement to the object
        rigidbody2d.velocity = new Vector2 (GameControl.instance.scrollSpeed, 0);
    }

    void Update()
    {
        //If game over is true, stop scrolling
        if (GameControl.instance.gameOver == true)
        {
            rigidbody2d.velocity = Vector2.zero;
        }
;  
    }
}
