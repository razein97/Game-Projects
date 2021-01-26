using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class EnemyDetection : MonoBehaviour
    {

        private Transform myTransform;
        private GameObject player;
        private float range;
        private float checkRate = 0.5f;
        private float nextCheck = 0f;
        private bool isPlayerFacingMe = false;
        private Enemy1Movement enemy1MovementScript;
        // private Animator playerAnim;
        public GameObject enemy1Attack;
        private float attackRate = 3f;
        private float nextAttack = 0f;



        void OnEnable()
        {
            SetInitialReferences();
        }

        void OnDisable()
        {

        }

        void Start()
        {
           // playerAnim = player.
        }

        void Update()
        {
           if(Time.time > nextCheck)
            {
                nextCheck = Time.time + checkRate;

                CheckIfPlayerIsFacingMeAndIsInRange();

                
            }

           if(Time.time > nextAttack)
            {
                nextAttack = Time.time + attackRate;

                Attack();
            }

            
        }

        void SetInitialReferences()
        {
            myTransform = this.transform;
            player = GameObject.Find("Player");
            enemy1MovementScript = GetComponent<Enemy1Movement>();
            
        }

        void CheckIfPlayerIsFacingMeAndIsInRange()
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 playerOther = player.transform.position - transform.position;
            if (Vector3.Dot(forward, playerOther) < 0)
            {
                //Debug.Log("Player is front of me");//This is because the game object rotation is flipped
                isPlayerFacingMe = true;
            }else if (Vector3.Dot(forward, playerOther) > 0)
            {
                isPlayerFacingMe = false;
            }
            
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player" && isPlayerFacingMe == true)
            {
                Attack();
            }
        }


        void OnTriggerStay2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                if (isPlayerFacingMe == true)
                {
                    enemy1MovementScript.enabled = false;
                    
                }
                else if(isPlayerFacingMe == false)
                {
                    enemy1MovementScript.enabled = true;
                }
                
            }
        }

        void OnTriggerExit2D(Collider2D other)
        {
            if(other.tag == "Player")
            {
                enemy1MovementScript.enabled = true;
            }
        }

        void Attack()
        {
            if(enemy1MovementScript.enabled == false)
            {
                Instantiate(enemy1Attack, myTransform.position, Quaternion.identity);
            }
            
        }

        
       

        


    }

}
