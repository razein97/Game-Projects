using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class AxeScript : MonoBehaviour
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
            if (other.tag == "Player")
            {
                PlayerStats ps = other.GetComponent<PlayerStats>();
                Animator anim = other.GetComponent<Animator>();
                ps.playerHealth -= 10f;
                am.Play("Player Hurt");
                anim.Play("Damaged");
            }
        }
    }

}

