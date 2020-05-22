using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gameone
{
    public class PlayerMovement : MonoBehaviour
    {
        
        public float speed;                //Floating point variable to store the player's movement speed.
        private Animator anim;
        private Rigidbody2D rb2d;        //Store a reference to the Rigidbody2D component required to use 2D Physics.

        // Use this for initialization
        void Start()
        {
            //Get and store a reference to the Rigidbody2D component so that we can access it.
            rb2d = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();

        }

        //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
        void FixedUpdate()
        {
            //Store the current horizontal input in the float moveHorizontal.
            float moveHorizontal = Input.GetAxisRaw("Horizontal");
            
            //Store the current vertical input in the float moveVertical.
            float moveVertical = Input.GetAxisRaw("Vertical");

            //Use the two store floats to create a new Vector2 variable movement.
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            movement.Normalize();

            
            
            
            rb2d.velocity = movement * speed;
            anim.SetFloat("Speed", rb2d.velocity.magnitude);

        }
    }
}