using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    //getting all components needed and setting variables
    private Animator animator;
    private Rigidbody2D rigidbody2d;

    public float verticalForce = 200f;
    private bool alive = true;

    //finishing start up 
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    
    //checking every frame for inputs
    void Update()
    {
        // if the bird is still alive
        if (alive == true)
        {
            //if the up arrow is pressed
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                // send signal to play fly animation
                animator.SetTrigger("Fly");
                //set y velocity to 0 and then give it upwards force
                rigidbody2d.velocity = Vector2.zero;
                rigidbody2d.AddForce(new Vector2(0, verticalForce));

            }
        }
    }

    //if the bird collides with anything...
    private void OnCollisionEnter2D(Collision2D other)
    {
        //make speed zero, set alive to false, send animator trigger to play death, and tell game (add later)
        rigidbody2d.velocity = Vector2.zero;
        alive = false;
        animator.SetTrigger("Die");
        
    }

}
