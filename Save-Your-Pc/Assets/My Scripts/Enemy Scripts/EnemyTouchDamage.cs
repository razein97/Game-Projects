using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class EnemyTouchDamage : MonoBehaviour
    {
        public float bulletDamage = 10f;
        public float damage = 10f;
        private float damageRate = 10f;
        private float pushBackForce = 20f;
        private float nextDamage = 0f;

        private Transform enemy1Transform;

        private Animator playerAnim;
        [SerializeField]
        private float health = 100f;

        private Animator enemyAnim;
        public GameObject enemy1;

        private BoxCollider2D enemy1Bc;

        AudioManager am;



        void OnEnable()
        {
            SetInitialReferences();
        }

        void OnDisable()
        {

        }

        void Start()
        {
            enemy1Bc = enemy1.GetComponent<BoxCollider2D>();
        }

        void Update()
        {
            if(health <= 0)
            {
                enemy1Bc.enabled = false;
                enemy1.SetActive(false);
                
            }
        }

        void SetInitialReferences()
        {
            enemy1Transform = GetComponentInParent<Transform>();
            playerAnim = GameObject.Find("Player").GetComponent<Animator>();
            enemyAnim = GetComponentInParent<Animator>();
            am = GameObject.Find("AudioManager").GetComponent<AudioManager>();
            
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if(other.tag == "Bullet")
            {
                am.Play("Enemy Hurt");
                health -= bulletDamage;
                enemyAnim.Play("EnemyDamaged");
                Destroy(other.gameObject);
            }
        }

        void OnTriggerStay2D(Collider2D other)
        {
            if (other.tag == "Player" && Time.time > nextDamage)
            {

                PlayerStats playerStats = other.gameObject.GetComponent<PlayerStats>();
                playerStats.playerHealth -= damage;
                nextDamage = Time.time + damageRate;

                am.Play("Player Hurt");
                playerAnim.Play("Damaged");

                PushBack(other.transform);
            }

            
        }

        

        //void OnTriggerExit2D(Collider2D other)
        //{
        //    if (other.tag == "Player")
        //    {

        //    }
        //}

        void PushBack(Transform pushedObject)
        {
            Vector2 pushDirection = new Vector2(0, (pushedObject.position.y - enemy1Transform.position.y)).normalized;
            pushDirection *= pushBackForce;
            Rigidbody2D pushRB = pushedObject.gameObject.GetComponent<Rigidbody2D>();
            pushRB.velocity = Vector2.zero;
            pushRB.AddForce(pushDirection, ForceMode2D.Impulse);

        }
    }

}

