using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class Enemy1Movement : MonoBehaviour
    {
        public LayerMask enemyMask;
        Rigidbody2D myBody;
        Transform myTransform;
        float myWidth;
        

        public float speed;


        void OnEnable()
        {
            SetInitialReferences();
        }

        void OnDisable()
        {

        }

        void Start()
        {

        }

        void Update()
        {

        }

        void SetInitialReferences()
        {
            myTransform = this.transform;
            myBody = this.GetComponent<Rigidbody2D>();
            SpriteRenderer mySprite = this.GetComponentInChildren<SpriteRenderer>();
            myWidth = mySprite.bounds.extents.x;
            //myHeight = mySprite.bounds.extents.y;
        }

        void FixedUpdate()
        {
            Vector2 lineCastPos = myTransform.position - myTransform.right * myWidth;
            //Vector2 lineCastPosY = myTransform.position - myTransform.up * myHeight;
            Debug.DrawLine(lineCastPos, lineCastPos + Vector2.down);
            bool isGrounded = Physics2D.Linecast(lineCastPos, lineCastPos + Vector2.down, enemyMask);
            Debug.DrawLine(lineCastPos, lineCastPos - myTransform.right.toVector2() * 0.5f);
            bool isBlocked = Physics2D.Linecast(lineCastPos, lineCastPos - myTransform.right.toVector2() * 1f, enemyMask);

            //if theres no ground turn around or if im blocked
            if (!isGrounded || isBlocked)
            {
                Vector3 currentRot = myTransform.eulerAngles;
                currentRot.y += 180;
                myTransform.eulerAngles = currentRot;
            }

            //Always move forward
            Vector2 myVel = myBody.velocity;
            myVel.x = -myTransform.right.x * speed;
            myBody.velocity = myVel;
        }

        
    }

}

