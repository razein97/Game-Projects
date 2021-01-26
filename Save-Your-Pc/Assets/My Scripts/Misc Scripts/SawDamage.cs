using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetaGameJam
{
    public class SawDamage : MonoBehaviour
    {

        AudioManager am;

        public float damageRate = 0.5f;
        public float nextDamage = 0f;

        void OnEnable()
        {
            SetInitialReferences();
        }

        void SetInitialReferences()
        {
            am = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        }

        void OnTriggerStay2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                PlayerStats ps = other.GetComponent<PlayerStats>();
                
                if(Time.time > nextDamage)
                {
                    nextDamage = Time.time + damageRate;
                    am.Play("Player Hurt");
                    ps.playerHealth -= 3f;
                }
            }
        }
    }

}
