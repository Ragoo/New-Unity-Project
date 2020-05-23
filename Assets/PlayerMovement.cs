using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

namespace gameone
{
    public class PlayerMovement : MonoBehaviour
    {
        
        public float speed;                
        private Animator anim;
        private Rigidbody2D rb2d;   
        private bool facingRight;

        void Start()
        {
            facingRight = true;

            rb2d = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();


        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && !anim.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.attack01"))
            {
               
                anim.SetBool("IsAttacking", true);

            }
            else
            {
                //anim.SetBool("IsAttacking", false);

            }
        }
        void FixedUpdate()
        {
            
            float moveHorizontal = Input.GetAxisRaw("Horizontal");
            
            
         
            float moveVertical = Input.GetAxisRaw("Vertical");

            Flip(moveHorizontal);

           
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            movement.Normalize();                      
           
            rb2d.velocity = movement * speed;
            anim.SetFloat("Speed", rb2d.velocity.magnitude);

        }

        private void Flip(float moveHorizontal)
        {
            if (moveHorizontal > 0 && !facingRight || moveHorizontal < 0 && facingRight)
            {
                facingRight = !facingRight;

                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
            }
        }
    }
}