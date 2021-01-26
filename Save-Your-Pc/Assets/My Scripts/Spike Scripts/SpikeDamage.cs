using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class SpikeDamage : MonoBehaviour
    {
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

        }

        void Update()
        {

        }

        void SetInitialReferences()
        {
            am = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if(other.tag == "Player")
            {
                PlayerStats ps = other.GetComponent<PlayerStats>();
                ps.playerHealth -= 100;
                Animator pa = other.GetComponent<Animator>();
                am.Play("Player Hurt");
                pa.Play("Damaged");
            }
        }
    }

}

