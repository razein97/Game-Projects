using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class Enemy1Attack : MonoBehaviour
    {
        AudioManager am;

        Rigidbody2D myRB;

        public float particleSpeed;

        public Vector2 directionFire;

        private PlayerStats playerStats;

        private Vector2 dir = new Vector2(0,0);


        void OnEnable()
        {
            playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
            am = GameObject.Find("AudioManager").GetComponent<AudioManager>();


        }

        void Awake()
        {
            myRB = GetComponent<Rigidbody2D>();
            myRB.AddForce(directionFire * particleSpeed, ForceMode2D.Impulse);

            

            
        }

        void Update()
        {
            dir = myRB.velocity;
            if(dir != Vector2.zero)
            {
                float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;

                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                //Audio
                am.Play("Player Hurt");

                playerStats.playerHealth -= 10f;
                Animator playerAnim = other.GetComponent<Animator>();
                playerAnim.Play("Damaged");
                Destroy(this.gameObject);
            }
        }

    }
}

