using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class PlayerMovement : MonoBehaviour
    {
        

        public float speed = 0f;
	   public float hoverSpeed = 100f;


        Rigidbody2D rb;
        public bool facingRight;


        void OnEnable()
        {
            SetInitialReferences();
            
        }

        void OnDisable()
        {

        }

        void Start()
        {
            facingRight = true;
        }

        void FixedUpdate()
        {
            InputCheck();
        }

        void SetInitialReferences()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void InputCheck()
        {
            float move = Input.GetAxis("Movement");
            
            
            

            rb.velocity = new Vector2(move * speed, rb.velocity.y);

            if (move > 0 && !facingRight)
            {
                Flip();

            }
            else if (move < 0 && facingRight)
            {
                Flip();

            }

            if (Input.GetButton("Hover Up"))
            {
                transform.Translate(Vector2.up * Time.deltaTime * hoverSpeed);
            }

            if (Input.GetButton("Hover Down"))
            {
                transform.Translate(-Vector2.up * Time.deltaTime * hoverSpeed);
            }

        }

        void Flip()
        {
            facingRight = !facingRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }
}


